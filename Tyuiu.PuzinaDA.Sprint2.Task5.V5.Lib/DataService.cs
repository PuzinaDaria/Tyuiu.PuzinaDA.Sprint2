using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PuzinaDA.Sprint2.Task5.V5.Lib
{
    public class DataService : ISprint2Task5V5
    {
        public string FindCardValue(int value)
        {
            string card;
            switch (value)
            {
                case (6) : 
                    card = "Шестёрка";
                    break;
                case (7):
                    card = "Семёрка";
                    break;
                case (8):
                    card = "Восьмёрка";
                    break;
                case (9):
                    card = "Девятка";
                    break;
                case (11):
                    card = ("Валет");
                    break;
                case (12):
                    card = ("Дама");
                    break;
                case (13):
                    card = ("Король");
                    break;
                case (14):
                    card = ("Туз");
                    break;
                default:
                    card = ("Такой карты нет");
                    break;

            }
            return card;
        }
    }
}
