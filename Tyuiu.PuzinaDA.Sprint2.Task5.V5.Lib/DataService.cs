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
                    card = "шестёрка";
                    break;
                case (7):
                    card = "семёрка";
                    break;
                case (8):
                    card = "восьмёрка";
                    break;
                case (9):
                    card = "девятка";
                    break;
                case (11):
                    card = ("валет");
                    break;
                case (12):
                    card = ("дама");
                    break;
                case (13):
                    card = ("король");
                    break;
                case (14):
                    card = ("туз");
                    break;
                default:
                    card = ("такой карты нет");
                    break;

            }
            return card;
        }
    }
}
