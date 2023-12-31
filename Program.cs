using NBA.Conection;
using NBA.Entities;
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
    public static Player User;
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Conexion.OpenConnection();
        MainMenu = new MainMenu();
        Classic = new Classic();
        TimeRush = new TimeRush();
        Application.Run(MainMenu);
        Conexion.CloseConnection();
    }
}