using Tyuiu.BurmistrovNS.Sprint2.Task1.V19.Lib;


namespace Tyuiu.BurmistrovNS.Sprint2.Task1.V19
{
    class Programm
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int a = 696;
            int b = 354;
            int c = 423;
            int d = 957;


            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);


            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                               *");
            Console.WriteLine("**********************************************************************************");

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);


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