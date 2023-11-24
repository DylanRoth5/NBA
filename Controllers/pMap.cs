using NBA.Conection;
using NBA.Entities;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA.Controllers
{
    internal class pMap
    {
        public static List<Map> GetAll()
        {
            var list = new List<Map>();
            var cmd = new SQLiteCommand("select Id, Size from Map");
            cmd.Connection = Conexion.Connection;
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var item = new Map
                {
                    Id = (int)(long)reader["Id"],
                    Size = (int)(long)reader["Size"]
                };
                list.Add(item);
            }
            return list;
        }
        public static void Save(Map item)
        {
            var cmd = new SQLiteCommand("insert into Map(Size) values(@Size)");
            cmd.Parameters.Add(new SQLiteParameter("@Size", item.Size));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }
        public static void Delete(Map item)
        {
            var cmd = new SQLiteCommand("delete from Map where Id = @Id");
            cmd.Parameters.Add(new SQLiteParameter("@Id", item.Id));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }
        //public static void update(Map item)
        //{
        //    var cmd = new SQLiteCommand("UPDATE Map SET Size = @Size WHERE Id = @Id");
        //    cmd.Parameters.Add(new SQLiteParameter("@Id", item.Id));
        //    cmd.Parameters.Add(new SQLiteParameter("@Size", item.Size));
        //    cmd.Parameters.Add(new SQLiteParameter("@Content", item.Content));
        //    cmd.Connection = Conexion.Connection;
        //    cmd.ExecuteNonQuery();
        //}
    }
}
