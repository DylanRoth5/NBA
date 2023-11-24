using NBA.Controllers;
using NBA.Entities;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace NBA.Forms;

public partial class TimeRush : Form
{

    private readonly Random _r = new();

    public TimeRush()
    {
        InitializeComponent();
    }

    private static Map? emap;

    private static int _smolShip;
    private static int _normalShip;
    private static int _bigShip;
    private static int _biggerShip;

    // Variable que indica si el juego está en curso
    private static bool _gaming;

    private void btnCoord_Click(object sender, EventArgs e)
    {
        // Obtener el botón que activó el evento
        var btn = (Button)sender;

        // Extraer las coordenadas del nombre del botón
        var temp = btn.Name.Split(';');
        int[] coords = { int.Parse(temp[0]), int.Parse(temp[1]) };

        // Verificar si el botón pertenece al panel del enemigo
        if (btn.Parent == plC)
        {
            // Lanzar un misil en las coordenadas especificadas en el mapa del enemigo
            emap = IMap.launchMissile(coords[0], coords[1], emap);

            // Actualizar la representación visual del mapa del enemigo
            foreach (Button butn in plC.Controls)
            {
                var temp2 = butn.Name.Split(';');
                int[] coords2 = { int.Parse(temp2[0]), int.Parse(temp2[1]) };

                // Cambiar el color del botón según el valor en la matriz del mapa del enemigo
                if (emap.Matrix[coords2[0], coords2[1]] == Map.Ship)
                {
                    butn.BackColor = Color.FromArgb(150, 50, 100, 250);
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
        }
        if (!IMap.hasShips(emap))
        {
            plC.Visible = false;
            pPanel.Visible = false;
            ll7.Visible = true;
            ll7.Text = @"You Won";
        }
        else
        {
            plC.Visible = false;
            pPanel.Visible = false;
            ll7.Visible = true;
            ll7.Text = @"You Lost";
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        emap = new Map();
        // Crear nuevos mapas para el enemigo y el jugador con el tamaño seleccionado
        emap = new Map(int.Parse(numericUpDown1.Value.ToString()));

        // Limpiar los mapas recién creados
        emap = IMap.cleanMap(emap);

        // Configuración inicial de la interfaz gráfica
        plC.Visible = true;
        ll7.Visible = false;

        // Configurar el tamaño de los paneles según el tamaño de los mapas
        var height = Size.Width / (17 + emap.Size);
        var width = Size.Width / (17 + emap.Size);
        plC.Size = new Size(width * emap.Size + 20, height * emap.Size + 20);

        // Inicializar contadores de barcos según los valores de los controles numericos
        _smolShip = int.Parse(numericUpDown2.Value.ToString());
        _normalShip = int.Parse(numericUpDown3.Value.ToString());
        _bigShip = int.Parse(numericUpDown4.Value.ToString());
        _biggerShip = int.Parse(numericUpDown5.Value.ToString());

        // Verificar si el juego aún no ha comenzado
        if (!_gaming)
        {
            // Configuración de la interfaz para el inicio del juego
            button1.Text = @"End Game";
            plC.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            _gaming = true;

            // Configuración de la interfaz para el mapa del enemigo
            var top = 10;
            var left = 10;
            for (var i = 0; i < emap.Size; i++)
            {
                for (var j = 0; j < emap.Size; j++)
                {
                    // Crear y configurar botón del mapa del enemigo
                    var button = new Button();
                    button.Left = left;
                    button.Top = top;
                    button.Width = width;
                    button.Height = height;
                    button.Margin = new Padding(0, 0, 0, 0);
                    button.FlatStyle = FlatStyle.Flat;
                    button.Location = new Point(left, top);
                    button.Name = i + ";" + j;
                    button.Text = i + @";" + j;
                    button.Click += btnCoord_Click!;
                    button.BackColor = Color.FromArgb(150, 50, 100, 250);
                    plC.Controls.Add(button); // Agregar botón al panel
                    top += button.Height;
                }

                left += width;
                top -= height * emap.Size;
            }
        }
        else
        {
            // Configuración de la interfaz para el final del juego
            plC.Visible = false;
            button1.Text = @"Start";
            _gaming = false;

            // Limpiar los controles de los paneles
            while (plC.Controls.Count > 0)
                foreach (Button button in plC.Controls)
                    plC.Controls.Remove(button);
        }
    }

    private void button7_Click(object sender, EventArgs e)
    {
        // IMatch.save(Match);

        // Habilitar la capacidad de atacar en el panel del enemigo
        plC.Enabled = true;

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
            emap = IMap.placeShip(eX, eY, 2, horisontal, emap);
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

            emap = IMap.placeShip(eX, eY, 3, horisontal, emap);
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

            emap = IMap.placeShip(eX, eY, 4, horisontal, emap);
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
            emap = IMap.placeShip(eX, eY, 5, horisontal, emap);
        }

        // Actualizar la representación visual en el panel del enemigo
        foreach (Button btn in plC.Controls) btn.BackColor = Color.FromArgb(150, 50, 100, 250);
    }

    private void btSoloClose_Click(object sender, EventArgs e)
    {
        Hide();
        Program.MainMenu!.Show();
    }
}