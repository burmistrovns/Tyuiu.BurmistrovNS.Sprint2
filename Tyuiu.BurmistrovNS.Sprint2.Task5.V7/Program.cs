using Tyuiu.BurmistrovNS.Sprint2.Task5.V7.Lib;
namespace Tyuiu.BurmistrovNS.Sprint2.Task5.V7
{
    class Programm
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                               *");
            Console.WriteLine("**********************************************************************************");

            Console.WriteLine("Введите год: ");
            int startYear = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество прошедших месяцев:");
            int n = Convert.ToInt32(Console.ReadLine());

            string res;
            if (n < 0)
            {
                res = "Введено неверное значение!";
            }
            else
            {
                res = "Это месяц: " + ds.FindMonthName(1990, n);
            }


            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                     *");
            Console.WriteLine("**********************************************************************************");

            Console.WriteLine($"С начала {startYear} года прошло " + n + " месяца(-ев) и 2 дня");

            Console.WriteLine(res);


            Console.ReadKey();

        }



    }




}