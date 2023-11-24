using NBA.Conection;
using NBA.Forms;

namespace NBA;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    public static MainMenu MainMenu;
    public static Classic Classic;
    public static TimeRush TimeRush;
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        Conexion.OpenConnection();
        ApplicationConfiguration.Initialize();
        MainMenu = new MainMenu();
        Classic = new Classic();
        TimeRush = new TimeRush();
        Application.Run(MainMenu);
        Conexion.CloseConnection();
    }
}