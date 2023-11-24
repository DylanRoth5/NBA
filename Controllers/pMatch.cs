using NBA.Conection;
using NBA.Entities;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NBA.Controllers
{
    internal class pMatch
    {
        public static List<Match> GetAll()
        {
            var list = new List<Match>();
            var cmd = new SQLiteCommand("select Id, PlayerId, PlayerMapId, PcMapId, Name from Match");
            cmd.Connection = Conexion.Connection;
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var match = new Match();
                match.Id = reader.GetInt32(0);
                match.PlayerId = reader.GetInt32(1);
                match.PlayerMapId = reader.GetInt32(2);
                match.PcMapId = reader.GetInt32(3);
                match.Name = reader.GetString(4);
                list.Add(match);
            }
            return list;
        }
        public static void Save(Match item)
        {
            var cmd = new SQLiteCommand("insert into Match(PlayerId, PlayerMapId, PcMapId, Name) values(@PlayerId, @PlayerMapId, @PcMapId, @Name)");
            cmd.Parameters.Add(new SQLiteParameter("@PlayerId", item.PlayerId));
            cmd.Parameters.Add(new SQLiteParameter("@PlayerMapId", item.PlayerMapId));
            cmd.Parameters.Add(new SQLiteParameter("@PcMapId", item.PcMapId));
            cmd.Parameters.Add(new SQLiteParameter("@Name", item.Name));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }
    }
}
