using Tyuiu.BurmistrovNS.Sprint2.Task7.V14.Lib;
namespace Tyuiu.BurmistrovNS.Sprint2.Task7.V14
{
    class Programm
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                               *");
            Console.WriteLine("***************************************************************************");

            bool res;

            double x;
            double y;

            Console.WriteLine("Введите координату X: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координату Y: ");
            y = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            res = ds.CheckDotInShadedArea(x, y);
            if (res)
            {
                Console.WriteLine("Точка находится в зашрихованной области");
            }
            else
            {
                Console.WriteLine("Точка не находится в зашрихованной области");
            }

            Console.ReadKey();

        }



    }




}