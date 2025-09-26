using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BurmistrovNS.Sprint2.Task0.V9.Lib
{
    public class DataService : ISprint2Task0V9
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            res[0] = x == y + 679;
            res[1] = x != y;
            res[2] = x < y + 1000;
            res[3] = x > y;
            res[4] = x <= y + 679;
            res[5] = x >= y + 1000;

            return res;

        }
    }
}