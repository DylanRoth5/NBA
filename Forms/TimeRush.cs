namespace NBA.Forms;

public partial class TimeRush : Form
{
    private List<Button> _shipPossitionButtons = null!;

    private readonly Random _r = new();

    private System.Windows.Forms.Timer _timer = null!;
    private TimeSpan _tiempoTranscurrido;

    public TimeRush()
    {
        InitializeComponent();
        initializeChronometer();
    }

    private void btCoopClose_Click(object sender, EventArgs e)
    {
        foreach (var button in _shipPossitionButtons) button.Visible = false;
        restartChronometer();
        Hide();
        Program.MainMenu!.Show();
    }

    private void initializeChronometer()
    {
        _timer = new System.Windows.Forms.Timer();
        _timer.Interval = 1000; //para que cuente bien los segundos
        _timer.Tick += Timer_Tick!;
    }

    private void Timer_Tick(object sender, EventArgs e)
    {
        //Actualizar la visualización del tiempo si es necesario
        _tiempoTranscurrido = _tiempoTranscurrido.Add(TimeSpan.FromSeconds(1));
    }

    private void button2_Click(object sender, EventArgs e)
    {
        //lista con todos los botones que forman la matriz de lugares donde hay barcos
        _shipPossitionButtons = new List<Button>
        {
            a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, c1, c2, c3, c4, c5, c6,
            c7, c8, c9, c10, d1, d2, d3, d4, d5, d6, d7, d8, d9, d10
        };

        //asigna a 5 botones el tag 'enemyShip' para que haya un barco en ese boton
        for (var i = 0; i < 5; i++)
        {
            var indiceAleatorio = _r.Next(_shipPossitionButtons.Count);
            _shipPossitionButtons[indiceAleatorio].Tag = "enemyShip";
        }

        //los botones estan ocultos antes de clickear start, este foreach los vuelve visibles
        foreach (var button in _shipPossitionButtons) button.Visible = true;

        //inicia el cronómetro 
        _tiempoTranscurrido = new TimeSpan();
        _timer.Start();
    }

    private void BotonPosicion_Click(object sender, EventArgs e)
    {
        //verifica si el botón clicado tiene el tag enemyShip
        var botonClicado = sender as Button;
        if (botonClicado != null && "enemyShip".Equals(botonClicado.Tag))
        {
            //realiza las acciones necesarias cuando se clickea un botón con el tag enemyShip
            MessageBox.Show(@"¡Encontraste un barco");

            //quita la propiedad para que no se pueda contar más de una vez
            botonClicado.Tag = null;
        }

        //devulve true cuando no haya ningun barco con el tag enemyShip y muestra q termino la partida
        if (_shipPossitionButtons.Any(button => "enemyShip".Equals((string?)button.Tag))) return;
        {
            _timer.Stop();
            MessageBox.Show($@"¡Ganaste la partida! Tiempo: {_tiempoTranscurrido.ToString(@"mm\:ss")}");
            foreach (var button in _shipPossitionButtons) button.Visible = false;
            Hide();
            Program.MainMenu!.Show();
            restartChronometer();
        }
    }

    private void restartChronometer()
    {
        _tiempoTranscurrido = new TimeSpan();
        _timer.Start();
    }
}