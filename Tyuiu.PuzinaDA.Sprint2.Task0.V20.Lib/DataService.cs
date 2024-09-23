﻿using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PuzinaDA.Sprint2.Task0.V20.Lib
{
    public class DataService : ISprint2Task0V20
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            res[0] = y + 800 == x;
            res[1] = y + 800 != x;
            res[2] = y < x;
            res[3] = y > x;
            res[4] = y <= x;
            res[5] = y >= x;
            return res;
        }
    }
}
