using Tyuiu.BurmistrovNS.Sprint2.Task0.V9.Lib;

namespace Tyuiu.BurmistrovNS.Sprint2.Task0.V9
{
    class Programm
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x = 1054;
            int y = 375;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                               *");
            Console.WriteLine("**********************************************************************************");

            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);


            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                     *");
            Console.WriteLine("**********************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);

            }

            Console.ReadKey();

        }



    }




}