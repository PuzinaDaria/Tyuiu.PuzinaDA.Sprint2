using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PuzinaDA.Sprint2.Task1.V12.Lib
{
    public class DataService : ISprint2Task1V12
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a > b) | (c != d);
            res[1] = (b + 36 == a) & (d < c);
            res[2] = (a >= b) || (d <= c);
            res[3] = (a == b) && (d > c);
            res[4] = !res[3];
            res[5] = (d == a)^(b == c);
            return res;
        }
    }
}
