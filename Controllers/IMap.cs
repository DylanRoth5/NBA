using System.Data.SQLite;
using NBA.Conection;
using NBA.Entities;

namespace NBA.Controllers;

public class IMap
{
    public static List<Map> getAll()
    {
        var list = new List<Map>();
        var cmd = new SQLiteCommand("select Id, Size, Content from Maps");
        cmd.Connection = Conexion.Connection;
        var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            var item = new Map
            {
                Id = (int)(long)reader["Id"],
                Size = (int)(long)reader["Size"],
                Content = (string)reader["Content"]
            };
            list.Add(item);
        }
        return list;
    }
    public static void save(Map item)
    {
        var cmd = new SQLiteCommand("insert into Maps(Size, Content) values(@Size, @Content)");
        cmd.Parameters.Add(new SQLiteParameter("@Size", item.Size));
        cmd.Parameters.Add(new SQLiteParameter("@Content", item.Content));
        cmd.Connection = Conexion.Connection;
        cmd.ExecuteNonQuery();
    }
    public static void delete(Map item)
    {
        var cmd = new SQLiteCommand("delete from Maps where Id = @Id");
        cmd.Parameters.Add(new SQLiteParameter("@Id", item.Id));
        cmd.Connection = Conexion.Connection;
        cmd.ExecuteNonQuery();
    }
    public static void update(Map item)
    {
        var cmd = new SQLiteCommand("UPDATE Maps SET Size = @Size, Content = @Content WHERE Id = @Id");
        cmd.Parameters.Add(new SQLiteParameter("@Id", item.Id));
        cmd.Parameters.Add(new SQLiteParameter("@Size", item.Size));
        cmd.Parameters.Add(new SQLiteParameter("@Content", item.Content));
        cmd.Connection = Conexion.Connection;
        cmd.ExecuteNonQuery();
    }

    public static Map cleanMap(Map? map)
    {
        for (var i = 0; i < map!.Size; i++)
            for (var j = 0; j < map.Size; j++)
                map.Matrix[i, j] = map.Water;
        return map;
    }

    public static bool isBombed(int x, int y, Map? map)
    {
        return map!.Matrix[x, y] == Map.WreckedShip || map.Matrix[x, y] == Map.FailedMissile;
    }

    public static bool isOccupied(int x, int y, int length, bool horizontal, Map? map)
    {
        for (var i = 0; i < length; i++)
            if (horizontal)
            {
                if (x > map!.Size - length)
                    return true;
                if (map.Matrix[x + i, y] == Map.Ship)
                    return true;
            }
            else
            {
                if (y > map!.Size - length)
                    return true;
                if (map.Matrix[x, y + i] == Map.Ship) return true;
            }

        return false;
    }

    public static Map placeShip(int x, int y, int lenght, bool horizontal, Map? map)
    {
        if (horizontal)
            for (var i = 0; i <= map!.Size - lenght; i++)
                for (var j = 0; j <= map.Size; j++)
                {
                    if (x != i || y != j) continue;
                    for (var k = 0; k < lenght; k++) map.Matrix[i + k, j] = Map.Ship;
                }
        else
            for (var i = 0; i <= map!.Size; i++)
                for (var j = 0; j <= map.Size - lenght; j++)
                {
                    if (x != i || y != j) continue;
                    for (var k = 0; k < lenght; k++) map.Matrix[i, j + k] = Map.Ship;
                }

        return map;
    }

    public static Map launchMissile(int x, int y, Map? map)
    {
        if (map!.Matrix[x, y] == Map.Ship)
            map.Matrix[x, y] = Map.WreckedShip;
        else map.Matrix[x, y] = Map.FailedMissile;
        return map;
    }

    public static bool hasShips(Map? map)
    {
        for (var i = 0; i < map!.Size; i++)
            for (var j = 0; j < map.Size; j++)
                if (map.Matrix[i, j] == Map.Ship)
                    return true;
        return false;
    }
}