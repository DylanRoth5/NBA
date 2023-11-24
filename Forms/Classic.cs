using NBA.Controllers;
using NBA.Entities;

namespace NBA.Forms;

public partial class Classic : Form
{
    public Classic()
    {
        InitializeComponent();
        // WindowState = FormWindowState.Maximized;
    }

    // Mapas para el jugador y el enemigo
    private static Map? emap;
    private static Map? pmap;
    private static Match match;
    // Variable que indica si la orientación de los barcos es horizontal
    private static bool _isHorizontal = true;

    // Contadores para el número de barcos de diferentes tamaños
    private static int _smolShip;
    private static int _normalShip;
    private static int _bigShip;
    private static int _biggerShip;

    // Variables que indican si se está colocando un barco de cierto tamaño
    private static bool _placingSmal;
    private static bool _placingNormal;
    private static bool _placingBig;
    private static bool _placingBigger;

    // Variable que indica si se está llevando a cabo un ataque
    private static bool _atacking;

    // Variable que indica si el juego está en curso
    private static bool _gaming;

    private void gSolo_Load(object sender, EventArgs e)
    {
    }

    private void btSoloClose_Click(object sender, EventArgs e)
    {
        Hide();
        Program.MainMenu!.Show();
    }

    private void label2_Click(object sender, EventArgs e)
    {
    }

    private void btnCoord_Click(object sender, EventArgs e)
    {
        // Obtener el botón que activó el evento
        var btn = (Spot)sender;

        // Extraer las coordenadas del nombre del botón
        var temp = btn.Name.Split(';');
        int[] coords = { int.Parse(temp[0]), int.Parse(temp[1]) };

        // Verificar si el botón pertenece al panel del enemigo
        if (btn.Parent == ePanel)
        {
            // Lanzar un misil en las coordenadas especificadas en el mapa del enemigo
            emap = IMap.launchMissile(coords[0], coords[1], emap);

            // Actualizar la representación visual del mapa del enemigo
            foreach (Button butn in ePanel.Controls)
            {
                var temp2 = butn.Name.Split(';');
                int[] coords2 = { int.Parse(temp2[0]), int.Parse(temp2[1]) };

                // Cambiar el color del botón según el valor en la matriz del mapa del enemigo
                if (emap.Matrix[coords2[0], coords2[1]] == Map.Ship)
                {
                    butn.BackColor = Color.FromArgb(150,  50,  100,  250);
                }
                else if (emap.Matrix[coords2[0], coords2[1]] == Map.WreckedShip)
                {
                    butn.BackColor = Color.FromArgb(150, 150, 10, 50);
                    butn.Enabled = false;
                }
                else if (emap.Matrix[coords2[0], coords2[1]] == Map.FailedMissile)
                {
                    butn.BackColor = Color.FromArgb(150, 25, 50, 200);
                    butn.Enabled = false;
                }
                else
                {
                    butn.BackColor = Color.FromArgb(150, 50, 100, 250);
                }
            }

            // Generar coordenadas aleatorias para el lanzamiento de misiles del enemigo
            var r = new Random();
            var eX = r.Next(0, emap.Size);
            var eY = r.Next(0, emap.Size);
            // Verificar que no se haya lanzado un misil previamente en esas coordenadas
            var attempt = 0;
            var bombed = IMap.isBombed(eX, eY, emap);
            while (bombed)
            {
                eX = r.Next(0, emap.Size - 1);
                eY = r.Next(0, emap.Size - 1);
                bombed = IMap.isBombed(eX, eY, emap);
                btn.IsBombed = bombed; // Almacena el estado del lugar
                attempt++;

                // Salir del bucle si se encuentra una posición válida o después de 50 intentos
                if (!bombed) break;
                if (attempt > 50) break;
            }

            // Lanzar un misil en las coordenadas aleatorias en el mapa del jugador
            pmap = IMap.launchMissile(eX, eY, pmap);

            // Actualizar la representación visual del mapa del jugador
            foreach (Button butn in pPanel.Controls)
            {
                var temp2 = butn.Name.Split(';');
                int[] coords2 = { int.Parse(temp2[0]), int.Parse(temp2[1]) };

                // Cambiar el color del botón según el valor en la matriz del mapa del jugador
                if (pmap.Matrix[coords2[0], coords2[1]] == Map.Ship)
                {
                    butn.BackColor = Color.Black;
                }
                else if (pmap.Matrix[coords2[0], coords2[1]] == Map.WreckedShip)
                {
                    butn.BackColor = Color.FromArgb(150, 150, 10, 50);
                    butn.Enabled = false;
                }
                else if (pmap.Matrix[coords2[0], coords2[1]] == Map.FailedMissile)
                {
                    butn.BackColor = Color.FromArgb(150, 25, 50, 200);
                    butn.Enabled = false;
                }
                else
                {
                    butn.BackColor = Color.FromArgb(150, 50, 100, 250);
                }
            }
        }
        // Manejar la lógica de ubicación de barcos si el botón pertenece al panel del jugador
        else if (btn.Parent == pPanel)
        {
            // ... (código para la colocación de barcos)
            if (_placingSmal)
                switch (_isHorizontal)
                {
                    case true when coords[0] < pmap!.Size - 1:
                        pmap = IMap.placeShip(coords[0], coords[1], 2, _isHorizontal, pmap, pPanel);
                        _smolShip--;
                        _placingSmal = false;
                        break;
                    case false when coords[1] < pmap!.Size - 1:
                        pmap = IMap.placeShip(coords[0], coords[1], 2, _isHorizontal, pmap, pPanel);
                        _smolShip--;
                        _placingSmal = false;
                        break;
                }

            if (_placingNormal)
                switch (_isHorizontal)
                {
                    case true when coords[0] < pmap!.Size - 2:
                        pmap = IMap.placeShip(coords[0], coords[1], 3, _isHorizontal, pmap, pPanel);
                        _normalShip--;
                        _placingNormal = false;
                        break;
                    case false when coords[1] < pmap!.Size - 2:
                        pmap = IMap.placeShip(coords[0], coords[1], 3, _isHorizontal, pmap, pPanel);
                        _normalShip--;
                        _placingNormal = false;
                        break;
                }

            if (_placingBig)
                switch (_isHorizontal)
                {
                    case true when coords[0] < pmap!.Size - 3:
                        pmap = IMap.placeShip(coords[0], coords[1], 4, _isHorizontal, pmap, pPanel);
                        _bigShip--;
                        _placingBig = false;
                        break;
                    case false when coords[1] < pmap!.Size - 3:
                        pmap = IMap.placeShip(coords[0], coords[1], 4, _isHorizontal, pmap, pPanel);
                        _bigShip--;
                        _placingBig = false;
                        break;
                }

            if (_placingBigger)
                switch (_isHorizontal)
                {
                    case true when coords[0] < pmap!.Size - 4:
                        pmap = IMap.placeShip(coords[0], coords[1], 5, _isHorizontal, pmap, pPanel);
                        _biggerShip--;
                        _placingBigger = false;
                        break;
                    case false when coords[1] < pmap!.Size - 4:
                        pmap = IMap.placeShip(coords[0], coords[1], 5, _isHorizontal, pmap, pPanel);
                        _biggerShip--;
                        _placingBigger = false;
                        break;
                }

            foreach (Button butn in pPanel.Controls)
            {
                butn.Enabled = true;
                var temp2 = butn.Name.Split(';');
                int[] coords2 = { int.Parse(temp2[0]), int.Parse(temp2[1]) };
                if (pmap!.Matrix[coords2[0], coords2[1]] == Map.Ship)
                    butn.BackColor = Color.Black;
                else if (pmap.Matrix[coords2[0], coords2[1]] == Map.WreckedShip)
                    butn.BackColor = Color.FromArgb(150, 150, 10, 50);
                else if (pmap.Matrix[coords2[0], coords2[1]] == Map.FailedMissile)
                    butn.BackColor = Color.FromArgb(150, 25, 50, 200);
                else
                    butn.BackColor = Color.FromArgb(150, 50, 100, 250);
            }

            if (_biggerShip == 0 && _bigShip == 0 && _normalShip == 0 && _smolShip == 0)
            {
                button7.Enabled = true;
                btDirection.Enabled = false;
            }
        }

        // Habilitar/deshabilitar botones de colocación de barcos según la disponibilidad de barcos
        btSmallShip.Enabled = _smolShip != 0;
        button3.Enabled = _normalShip != 0;
        button4.Enabled = _bigShip != 0;
        button5.Enabled = _biggerShip != 0;

        // Habilitar el panel de barcos si no se está atacando
        if (!_atacking) shipPanel.Enabled = true;
        if (!_atacking) return;
        // Verificar el resultado del juego
        if (IMap.hasShips(emap))
        {
            if (IMap.hasShips(pmap)) return;
            // El jugador perdió
            // ... (código para el mensaje de fin de juego)
            shipPanel.Visible = false;
            ePanel.Visible = false;
            pPanel.Visible = false;
            label7.Visible = true;
            label7.Text = @"You Lost";
            btStart.Text = @"Reset";
        }
        else
        {
            if (IMap.hasShips(pmap))
            {
                // El jugador ganó
                // ... (código para el mensaje de fin de juego)
                shipPanel.Visible = false;
                ePanel.Visible = false;
                pPanel.Visible = false;
                label7.Visible = true;
                label7.Text = @"You Won";
                btStart.Text = @"Reset";
            }
            else
            {
                // Empate
                // ... (código para el mensaje de fin de juego)
                shipPanel.Visible = false;
                ePanel.Visible = false;
                pPanel.Visible = false;
                label7.Visible = true;
                label7.Text = @"Both Lost";
                btStart.Text = @"Reset";
            }
        }
    }

    private void btStart_Click(object sender, EventArgs e)
    {
        pmap = new Map();
        emap = new Map();
        // Match.Player = Program.CurrentUser;
        // Match.Finished = false;
        // Crear nuevos mapas para el enemigo y el jugador con el tamaño seleccionado
        emap = new Map(int.Parse(numericUpDown1.Value.ToString()));
        pmap = new Map(int.Parse(numericUpDown1.Value.ToString()));

        // Limpiar los mapas recién creados
        emap = IMap.cleanMap(emap);
        pmap = IMap.cleanMap(pmap);

        // Configuración inicial de la interfaz gráfica
        ePanel.Visible = true;
        pPanel.Visible = true;
        label7.Visible = false;
        shipPanel.Visible = true;

        // Configurar el tamaño de los paneles según el tamaño de los mapas
        var height = Size.Width / (17 + emap.Size);
        var width = Size.Width / (17 + emap.Size);
        ePanel.Size = new Size(width * emap.Size + 20, height * emap.Size + 20);
        pPanel.Left = ePanel.Left + width * emap.Size + 20;
        pPanel.Size = new Size(width * pmap.Size + 20, height * pmap.Size + 20);

        // Inicializar contadores de barcos según los valores de los controles numericos
        _smolShip = int.Parse(numericUpDown2.Value.ToString());
        _normalShip = int.Parse(numericUpDown3.Value.ToString());
        _bigShip = int.Parse(numericUpDown4.Value.ToString());
        _biggerShip = int.Parse(numericUpDown5.Value.ToString());

        // Verificar si el juego aún no ha comenzado
        if (!_gaming)
        {
            _isHorizontal = button6.Text == @"Horizontal";

            // Configuración de la interfaz para el inicio del juego
            btStart.Text = @"End Game";
            ePanel.Enabled = false;
            pPanel.Enabled = true;
            shipPanel.Enabled = true;
            btSmallShip.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            btDirection.Enabled = true;
            _gaming = true;

            // Configuración de la interfaz para el mapa del enemigo
            var top = 10;
            var left = 10;
            for (var i = 0; i < emap.Size; i++)
            {
                for (var j = 0; j < emap.Size; j++)
                {
                    // Crear y configurar botón del mapa del enemigo
                    var spot = new Spot();
                    spot.Left = left;
                    spot.Top = top;
                    spot.Width = width;
                    spot.Height = height;
                    spot.Margin = new Padding(0, 0, 0, 0);
                    spot.FlatStyle = FlatStyle.Flat;
                    spot.Location = new Point(left, top);
                    spot.Name = i + ";" + j;
                    spot.Text = i + @";" + j;
                    spot.Click += btnCoord_Click!;
                    spot.BackColor = Color.FromArgb(150, 50, 100, 250);
                    spot.Row = i; // Guardar la fila
                    spot.Column = j; // Guardar la columna
                    spot.IsBombed = false;
                    ePanel.Controls.Add(spot); // Agregar botón al panel
                    top += spot.Height;
                }
                left += width;
                top -= height * emap.Size;
            }

            // Configuración de la interfaz para el mapa del jugador
            top = 10;
            left = 10;
            for (var i = 0; i < emap.Size; i++)
            {
                for (var j = 0; j < emap.Size; j++)
                {
                    // Crear y configurar botón del mapa del jugador
                    var spot = new Spot();
                    spot.Left = left;
                    spot.Top = top;
                    spot.Width = width;
                    spot.Height = height;
                    spot.FlatStyle = FlatStyle.Flat;
                    spot.Location = new Point(left, top);
                    spot.Name = i + ";" + j;
                    spot.Text = i + @";" + j;
                    spot.Click += btnCoord_Click!;
                    spot.BackColor = Color.FromArgb(150, 50, 100, 250);
                    spot.Row = i; // Guardar la fila
                    spot.Column = j; // Guardar la columna
                    spot.IsBombed = false;
                    pPanel.Controls.Add(spot); // Agregar botón al panel
                    top += spot.Height;
                }
                left += width;
                top -= height * emap.Size;
            }
        }
        else
        {
            // Configuración de la interfaz para el final del juego
            ePanel.Visible = false;
            pPanel.Visible = false;
            shipPanel.Visible = false;
            btStart.Text = @"Start";
            _gaming = false;
            _atacking = false;

            // Limpiar los controles de los paneles
            while (ePanel.Controls.Count > 0)
                foreach (Spot spot in ePanel.Controls)
                    ePanel.Controls.Remove(spot);
            while (pPanel.Controls.Count > 0)
                foreach (Spot spot in pPanel.Controls)
                    pPanel.Controls.Remove(spot);
        }
    }
    private void gmPanel_Paint(object sender, PaintEventArgs e)
    {
    }

    private void gSolo_FormClosed(object sender, FormClosedEventArgs e)
    {
        Hide();
        Program.MainMenu!.Show();
    }

    private void gSolo_FormClosing(object sender, FormClosingEventArgs e)
    {
        Hide();
        Program.MainMenu!.Show();
    }

    private void btDirection_Click(object sender, EventArgs e)
    {
        if (btDirection.Text == @"Horizontal")
        {
            btDirection.Text = @"Vertical";
            _isHorizontal = false;
        }
        else
        {
            btDirection.Text = @"Horizontal";
            _isHorizontal = true;
        }
    }

    private void btSmallShip_Click(object sender, EventArgs e)
    {
        if (_smolShip > 0)
        {
            _placingSmal = true;
            shipPanel.Enabled = false;
        }

        btSmallShip.Enabled = false;
    }

    private void button3_Click(object sender, EventArgs e)
    {
        if (_normalShip > 0)
        {
            _placingNormal = true;
            shipPanel.Enabled = false;
        }
        
        if (_isHorizontal)
        {
            foreach (Button item in pPanel.Controls)
            {
                var name = $"{int.Parse(item.Name[0].ToString())-1};{item.Name[2]}";
                var name2 = $"{int.Parse(item.Name[0].ToString()) - 2};{item.Name[2]}";
                if (item.BackColor == Color.Black)
                    foreach (Button item2 in pPanel.Controls)
                    {
                        if (name == item2.Name) item2.Enabled = false;
                        if (name2 == item2.Name) item2.Enabled = false;
                        if (int.Parse(item2.Name[0].ToString()) >= pmap.Size-2) item2.Enabled = false;
                    }
            }
        }
        else
        {
            foreach (Button item in pPanel.Controls)
            {
                var name = $"{item.Name[0]};{int.Parse(item.Name[2].ToString())-1}";
                var name2 = $"{item.Name[0]};{int.Parse(item.Name[2].ToString())-2}";
                if (item.BackColor == Color.Black)
                    foreach (Button item2 in pPanel.Controls)
                    {
                        if (name == item2.Name) item2.Enabled = false;
                        if (name2 == item2.Name) item2.Enabled = false;
                        if (int.Parse(item2.Name[2].ToString()) >= pmap.Size-2) item2.Enabled = false;
                    }
            }
        }


        button3.Enabled = false;
    }

    private void button4_Click(object sender, EventArgs e)
    {
        if (_bigShip > 0)
        {
            _placingBig = true;
            shipPanel.Enabled = false;
        }
        if (_isHorizontal)
        {
            foreach (Button item in pPanel.Controls)
            {
                var name = $"{int.Parse(item.Name[0].ToString())-1};{item.Name[2]}";
                var name2 = $"{int.Parse(item.Name[0].ToString()) - 2};{item.Name[2]}";
                var name3 = $"{int.Parse(item.Name[0].ToString()) - 3};{item.Name[2]}";
                if (item.BackColor == Color.Black)
                    foreach (Button item2 in pPanel.Controls)
                    {
                        if (name == item2.Name) item2.Enabled = false;
                        if (name2 == item2.Name) item2.Enabled = false;
                        if (name3 == item2.Name) item2.Enabled = false;
                        if (int.Parse(item2.Name[0].ToString()) >= pmap.Size-3) item2.Enabled = false;
                    }
            }
        }
        else
        {
            foreach (Button item in pPanel.Controls)
            {
                var name = $"{item.Name[0]};{int.Parse(item.Name[2].ToString())-1}";
                var name2 = $"{item.Name[0]};{int.Parse(item.Name[2].ToString())-2}";
                var name3 = $"{item.Name[0]};{int.Parse(item.Name[2].ToString())-3}";
                if (item.BackColor == Color.Black)
                    foreach (Button item2 in pPanel.Controls)
                    {
                        if (name == item2.Name) item2.Enabled = false;
                        if (name2 == item2.Name) item2.Enabled = false;
                        if (name3 == item2.Name) item2.Enabled = false;
                        if (int.Parse(item2.Name[2].ToString()) >= pmap.Size-3) item2.Enabled = false;
                    }
            }
        }

        button4.Enabled = false;
    }

    private void button5_Click(object sender, EventArgs e)
    {
        if (_biggerShip > 0)
        {
            _placingBigger = true;
            shipPanel.Enabled = false;
        }
        if (_isHorizontal)
        {
            foreach (Button item in pPanel.Controls)
            {
                var name = $"{int.Parse(item.Name[0].ToString())-1};{item.Name[2]}";
                var name2 = $"{int.Parse(item.Name[0].ToString()) - 2};{item.Name[2]}";
                var name3 = $"{int.Parse(item.Name[0].ToString()) - 3};{item.Name[2]}";
                var name4 = $"{int.Parse(item.Name[0].ToString()) - 4};{item.Name[2]}";
                if (item.BackColor == Color.Black)
                    foreach (Button item2 in pPanel.Controls)
                    {
                        if (name == item2.Name) item2.Enabled = false;
                        if (name2 == item2.Name) item2.Enabled = false;
                        if (name3 == item2.Name) item2.Enabled = false;
                        if (name4 == item2.Name) item2.Enabled = false;
                        if (int.Parse(item2.Name[0].ToString()) >= pmap.Size-4) item2.Enabled = false;
                    }
            }
        }
        else
        {
            foreach (Button item in pPanel.Controls)
            {
                var name = $"{item.Name[0]};{int.Parse(item.Name[2].ToString())-1}";
                var name2 = $"{item.Name[0]};{int.Parse(item.Name[2].ToString())-2}";
                var name3 = $"{item.Name[0]};{int.Parse(item.Name[2].ToString())-3}";
                var name4 = $"{item.Name[0]};{int.Parse(item.Name[2].ToString())-4}";
                if (item.BackColor == Color.Black)
                    foreach (Button item2 in pPanel.Controls)
                    {
                        if (name == item2.Name) item2.Enabled = false;
                        if (name2 == item2.Name) item2.Enabled = false;
                        if (name3 == item2.Name) item2.Enabled = false;
                        if (name4 == item2.Name) item2.Enabled = false;
                        if (int.Parse(item2.Name[2].ToString()) >= pmap.Size-4) item2.Enabled = false;
                    }
            }
        }

        button5.Enabled = false;
    }

    private void button7_Click(object sender, EventArgs e)
    {
        // IMatch.save(Match);

        // Deshabilitar la capacidad de colocar barcos en el panel del jugador
        pPanel.Enabled = false;

        // Habilitar la capacidad de atacar en el panel del enemigo
        ePanel.Enabled = true;

        // Deshabilitar el panel de barcos
        shipPanel.Visible = false;

        // Establecer la bandera de ataque a verdadera
        _atacking = true;

        // Crear un generador de números aleatorios
        var r = new Random();

        // Variables para determinar la orientación de los barcos
        bool horisontal;
        int eX;
        int eY;
        int attempt;

        // Colocar barcos en el mapa del enemigo
        for (var i = 0; i < int.Parse(numericUpDown2.Value.ToString()); i++)
        {
            // Determinar aleatoriamente la orientación del barco (horizontal o vertical)
            horisontal = r.Next(0, 1) == 0; // 0 o 1 para determinar horizontal o vertical

            // Obtener coordenadas aleatorias para la posición del barco
            eX = r.Next(0, emap!.Size);
            eY = r.Next(0, emap.Size);
            // Inicializar contador de intentos y verificar si la posición está ocupada
            attempt = 0;
            var occupied = IMap.isOccupied(eX, eY, 2, horisontal, emap);
            // Repetir hasta encontrar una posición no ocupada o superar un límite de intentos
            while (occupied)
            {
                eX = r.Next(0, emap.Size);
                eY = r.Next(0, emap.Size);
                occupied = IMap.isOccupied(eX, eY, 2, horisontal, emap);
                attempt++;
                if (!occupied) break;
                if (attempt > 50) break;
            }

            // Colocar el barco en la posición encontrada
            emap = IMap.placeShip(eX, eY, 2, horisontal, emap, ePanel);
        }

        // Repetir el proceso para los otros tamaños de barco
        for (var i = 0; i < int.Parse(numericUpDown3.Value.ToString()); i++)
        {
            horisontal = r.Next(0, 1) == 0;
            eX = r.Next(0, emap!.Size);
            eY = r.Next(0, emap.Size);
            attempt = 0;
            var occupied = IMap.isOccupied(eX, eY, 3, horisontal, emap);
            while (occupied)
            {
                eX = r.Next(0, emap.Size);
                eY = r.Next(0, emap.Size);
                occupied = IMap.isOccupied(eX, eY, 3, horisontal, emap);
                attempt++;
                if (!occupied) break;
                if (attempt > 50) break;
            }

            emap = IMap.placeShip(eX, eY, 3, horisontal, emap, ePanel);
        }

        for (var i = 0; i < int.Parse(numericUpDown4.Value.ToString()); i++)
        {
            horisontal = r.Next(0, 1) == 0;
            eX = r.Next(0, emap!.Size);
            eY = r.Next(0, emap.Size);
            attempt = 0;
            var occupied = IMap.isOccupied(eX, eY, 4, horisontal, emap);
            while (occupied)
            {
                eX = r.Next(0, emap.Size);
                eY = r.Next(0, emap.Size);
                occupied = IMap.isOccupied(eX, eY, 4, horisontal, emap);
                attempt++;
                if (!occupied) break;
                if (attempt > 50) break;
            }

            emap = IMap.placeShip(eX, eY, 4, horisontal, emap, ePanel);
        }

        for (var i = 0; i < int.Parse(numericUpDown5.Value.ToString()); i++)
        {
            horisontal = r.Next(0, 1) == 0;
            eX = r.Next(0, emap!.Size);
            eY = r.Next(0, emap.Size);
            attempt = 0;
            var occupied = IMap.isOccupied(eX, eY, 5, horisontal, emap);
            while (occupied)
            {
                eX = r.Next(0, emap.Size);
                eY = r.Next(0, emap.Size);
                occupied = IMap.isOccupied(eX, eY, 5, horisontal, emap);
                attempt++;
                if (!occupied) break;
                if (attempt > 50) break;
            }
            emap = IMap.placeShip(eX, eY, 5, horisontal, emap, ePanel);
        }

        // Actualizar la representación visual en el panel del enemigo
        foreach (Button btn in ePanel.Controls) btn.BackColor = Color.FromArgb(150, 50, 100, 250);
    }

    private void btSave_Click(object sender, EventArgs e)
    {
        if (_gaming)
        {
            pMap.Save(emap);
            pMap.Save(pmap);
            foreach (Spot spot in ePanel.Controls)
            {
                pSpot.Save(spot);
            }
            foreach (Spot spot in pPanel.Controls)
            {
                pSpot.Save(spot);
            }
            match = new Match();
            match.PlayerId = Program.User.Id;
            match.PlayerMapId = pmap.Id;
            match.PcMapId = emap.Id;
            match.Name = DateTime.Now.ToString();
            pMatch.Save(match);
            Hide();
            Program.MainMenu!.Show();
        }
    }
}