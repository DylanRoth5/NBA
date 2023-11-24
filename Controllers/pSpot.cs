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
    internal class pSpot
    {
        public static List<Spot> GetAll()
        {
            var list = new List<Spot>();
            var cmd = new SQLiteCommand("select Id, IsBombed, Row, Column, MapId, Ship from Spot");
            cmd.Connection = Conexion.Connection;
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var spot = new Spot();
                spot.Id = reader.GetInt32(0);
                spot.IsBombed = (reader.GetInt32(1) == 1) ? true : false;
                spot.Row = reader.GetInt32(2);
                spot.Column = reader.GetInt32(3);
                spot.MapId = reader.GetInt32(4);
                spot.Ship = reader.GetInt32(5);
                list.Add(spot);
            }
            return list;
        }
        public static void Save(Spot item)
        {
            var cmd = new SQLiteCommand("insert into Spot(IsBombed, Row, Column, MapId, Ship) values(@IsBombed, @Row, @Column, @MapId, @Ship)");
            int bombed = (item.IsBombed) ? 1 : 0;
            cmd.Parameters.Add(new SQLiteParameter("@IsBombed", bombed));
            cmd.Parameters.Add(new SQLiteParameter("@Row", item.Row));
            cmd.Parameters.Add(new SQLiteParameter("@Column", item.Column));
            cmd.Parameters.Add(new SQLiteParameter("@MapId", item.MapId));
            cmd.Parameters.Add(new SQLiteParameter("@Ship", item.Ship));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }
        //public static void Delete(Spot item)
        //{
        //    var cmd = new SQLiteCommand("delete from Spot where Id = @Id");
        //    //cmd.Parameters.Add(new SQLiteParameter("@Id", item.Id));
        //    cmd.Connection = Conexion.Connection;
        //    cmd.ExecuteNonQuery();
        //}
        //public static void update(Spot item)
        //{
        //    var cmd = new SQLiteCommand("UPDATE Spot SET Size = @Size WHERE Id = @Id");
        //    cmd.Parameters.Add(new SQLiteParameter("@Id", item.Id));
        //    cmd.Parameters.Add(new SQLiteParameter("@Size", item.Size));
        //    cmd.Parameters.Add(new SQLiteParameter("@Content", item.Content));
        //    cmd.Connection = Conexion.Connection;
        //    cmd.ExecuteNonQuery();
        //}
    }
}
