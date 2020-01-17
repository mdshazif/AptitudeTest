using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Aptitude apt = new Aptitude();
            #region 1.Challenge
            int[] input1 = { 1, 2, 1, 5, 5, 3, 3, 3, 4 };
            var res1 = apt.Challenge(input1);
            Console.WriteLine(res1);
            #endregion

            Console.ReadLine();
        }
    }

    public class Aptitude
    {
        #region 1.Challenge
        public int Challenge(int[] input)
        {
            Dictionary<int, int> dicItems = new Dictionary<int, int>();
            //Need to optimize the below code - Todo
            foreach (int value in input)
            {
                if (!dicItems.ContainsKey(value))
                    dicItems.Add(value, input.Where(item => value == item).Count());
            }
            int maxValue = dicItems.Max(item => item.Value);
            List<int> lstBigComb = new List<int>();
            foreach (int key in input)
            {
                if (dicItems.ContainsKey(key) && dicItems[key] >= (maxValue - 1))
                {
                    lstBigComb.Add(key);
                }
            }

            int BigCombNumber = -1;
            for (int idx = 0; idx < lstBigComb.Count - 1; idx++)
            {
                var sumNumber = lstBigComb[idx] + lstBigComb[idx + 1];
                if (BigCombNumber < sumNumber)
                    BigCombNumber = sumNumber;
            }
            return BigCombNumber;
        }
        #endregion

    }
}

