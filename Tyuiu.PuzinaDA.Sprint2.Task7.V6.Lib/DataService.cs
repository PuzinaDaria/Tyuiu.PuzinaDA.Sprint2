using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PuzinaDA.Sprint2.Task7.V6.Lib
{
    public class DataService : ISprint2Task7V6
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if(((Math.Pow(x, 2) + Math.Pow(y, 2)) <= 4) && (y >= 0 && y <= 4))
            {
                if (((Math.Pow(x, 2) + Math.Pow(y, 2)) < 1) && (y >= 0 && y < 1))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
