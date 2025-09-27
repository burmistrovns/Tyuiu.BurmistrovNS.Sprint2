using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.BurmistrovNS.Sprint2.Task1.V19.Lib
{
    public class DataService : ISprint2Task1V19
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = c == b + 69 | a > c;
            res[1] = a != b & c == b;
            res[2] = b < c || b != a;
            res[3] = b != a && c > d;
            res[4] = !(res[1]);
            res[5] = a >= b ^ b+69 ==c;

            return res;



        }
    }
}
