using System.Data.SQLite;
using NBA.Entities;

namespace NBA.Conection
{
    internal class pPlayer
    {
        public static List<Player> GetAll()
        {
            var players = new List<Player>();
            var cmd = new SQLiteCommand("SELECT Id, Nick, Password FROM Player");
            cmd.Connection = Conexion.Connection;
            var obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {
                var a = new Player
                {
                    Id = obdr.GetInt32(0),
                    User = obdr.GetString(2),
                    Password = obdr.GetString(3)
                };
                players.Add(a);
            }
            return players;
        }

        public static Player GetByUsername(string username)
        {
            var a = new Player();
            var cmd = new SQLiteCommand("SELECT Id, Nick, Password FROM Player Where Nick =  @user");
            cmd.Parameters.Add(new SQLiteParameter("@user", username));
            cmd.Connection = Conexion.Connection;
            var obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {

                a.Id = obdr.GetInt32(0);
                a.User = obdr.GetString(2);
                a.Password = obdr.GetString(3);
            }
            return a;
        }

        public static Player GetById(int id)
        {
            var a = new Player();
            var cmd = new SQLiteCommand("SELECT Id, Nick, Password FROM Player Where Id =  @id");
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            cmd.Connection = Conexion.Connection;
            var obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {

                a.Id = obdr.GetInt32(0);
                a.User = obdr.GetString(2);
                a.Password = obdr.GetString(3);
            }
            return a;
        }

        public static void Insert(Player u)
        {
            var cmd = new SQLiteCommand("Insert Into Player(Nick, Password) VALUES (@user, @password)");
            cmd.Parameters.Add(new SQLiteParameter("@user", u.User));
            cmd.Parameters.Add(new SQLiteParameter("@password", u.Password));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }
    }
}
