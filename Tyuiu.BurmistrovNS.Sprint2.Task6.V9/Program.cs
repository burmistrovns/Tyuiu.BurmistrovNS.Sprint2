using Tyuiu.BurmistrovNS.Sprint2.Task6.V9.Lib;
namespace Tyuiu.BurmistrovNS.Sprint2.Task6.V9
{
    class Programm
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите день: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите месяц: ");
            int m = Convert.ToInt32(Console.ReadLine());

            string res;

            if ((m < 1) || (m > 12) || (n < 1) || (n > 31))
            {
                res = "Введенно неверное значение!";
            }
            else
            {
                res = "Дата следующего дня: " + ds.FindDateOfNextDay(m, n);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Дата следующего дня: " + res);
            Console.ReadKey();

        }



    }




}