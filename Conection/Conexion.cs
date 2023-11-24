using System.Data.SQLite;

namespace NBA.Conection
{
    class Conexion
    {
        private const string Cadena = "Data Source=Navy.db";

        public static void OpenConnection()
        {
            if (Connection.State == System.Data.ConnectionState.Closed)
            {
                Connection.Open();
            }
        }

        public static void CloseConnection()
        {
            Connection.Close();
        }

        //constructor de la variable connection  
        public static SQLiteConnection Connection { set; get; } = new (Cadena);
    }

}
