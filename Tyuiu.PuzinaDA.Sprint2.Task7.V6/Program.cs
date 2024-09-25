using Tyuiu.PuzinaDA.Sprint2.Task7.V6.Lib;
namespace Tyuiu.PuzinaDA.Sprint2.Task7.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Пузина Д. А. | ИИПБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Пузина Дарья Алексеевна | ИИПБ-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные           *");
            Console.WriteLine("* (вещественные значения) и вычисляет, находится ли точка с координатами  *");
            Console.WriteLine("* X,Y в заштрихованной области.                                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x, y;
            Console.Write("Введите координату X: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координату Y: ");
            y = Convert.ToDouble(Console.ReadLine());

            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (res)
            {
                Console.WriteLine("Точка в заштрихованной области");
            }
            else
            {
                Console.WriteLine("Точка в незаштрихованной области");
            }
        }
    }
}
