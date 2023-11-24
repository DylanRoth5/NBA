using System.Data.SQLite;
using NBA.Conection;
using NBA.Entities;

namespace NBA.Controllers;

public class IMap
{
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

    public static Map placeShip(int x, int y, int lenght, bool horizontal, Map? map, Panel panel)
    {
        if (horizontal)
            for (var i = 0; i <= map!.Size - lenght; i++)
                for (var j = 0; j <= map.Size; j++)
                {
                    if (x != i || y != j) continue;
                    for (var k = 0; k < lenght; k++)
                    {
                        map.Matrix[i + k, j] = Map.Ship;
                        ISpot.GetSpotByPosition(panel, x, y).Ship = Map.Ship;
                    }
                }
        else
            for (var i = 0; i <= map!.Size; i++)
                for (var j = 0; j <= map.Size - lenght; j++)
                {
                    if (x != i || y != j) continue;
                    for (var k = 0; k < lenght; k++)
                    {
                        map.Matrix[i, j + k] = Map.Ship;
                        ISpot.GetSpotByPosition(panel, x, y).Ship = Map.Ship;
                    }
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