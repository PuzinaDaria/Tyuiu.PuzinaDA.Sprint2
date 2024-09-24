using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PuzinaDA.Sprint2.Task4.V25.Lib
{
    public class DataService : ISprint2Task4V25
    {
        public double Calculate(double x, double y)
        {
            return (x - 20 * 2 < y / 4) ? Math.Round ((Math.Pow((1 + (2 / Math.Pow(x, 2))), y)), 3) :
                Math.Round((y + Math.Pow(((x + 1) / (y + 2)), x)), 3);
        }
    }
}
