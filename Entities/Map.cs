﻿namespace NBA.Entities
{

    public class Map
    {
        public int Id;
        public int Size;
        public string Content;
        public static int Ship = 1;
        public static int WreckedShip = 2;
        public static int FailedMissile = 3;
        public int Water = 0;
        public int[,] Matrix;

        public Map()
        {
            
        }

        public Map(int size)
        {
            Size = size;
            Matrix = new int[Size, Size];
        }
    }
}