using System;
using Tyuiu.PuzinaDA.Sprint2.Task4.V25.Lib;
namespace Tyuiu.PuzinaDA.Sprint2.Task4.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Пузина Д. А. | ИИПБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Тернарный оператор                                                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Пузина Дарья Алексеевна | ИИПБ-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с              *");
            Console.WriteLine("* использованием тернарного оператора, где пользователь вводит значение   *");
            Console.WriteLine("* переменных x, y с клавиатуры, если х - 20 * 2 < y / 4, то               *");
            Console.WriteLine("*                 y                   x                                   *");
            Console.WriteLine("*     (       2  )            ( x+1  )                                    *");
            Console.WriteLine("* z = (1 +  -----), иначе y + (------)                                    *");
            Console.WriteLine("*     (        2 )            ( y+2  )                                    *");
            Console.WriteLine("*     (       x  )            (      )                                    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x, y;
            Console.WriteLine("Введите Х: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите Y: ");
            y = Convert.ToDouble(Console.ReadLine());

            var z = ds.Calculate(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("z = " + z);

        }
    }
}
