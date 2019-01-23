using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> map = new Dictionary<int, string>
            {
                [0] = "Null",
                [1] = "Eins",
                [2] = "Zwei",
                [3] = "Drei",
                [4] = "Vier",
                [5] = "Fünf",
                [6] = "Sechs",
                [7] = "Sieben",
                [8] = "Acht",
                [9] = "Neun"
            };
        }

        static string Int2String(int i, Dictionary<int, string> map)
        {
            StringBuilder sb = new StringBuilder();
            string number = i.ToString();
            foreach (char c in number)
            {
                sb.Append(map[int.Parse(c.ToString())]);
            }
            return sb.ToString();
        }

        static string StringKonkat(string[] array)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string s in array) 
            {
                sb.Append(s);
            }
            return sb.ToString();
        }

        static int ArraySum(int[] array)
        {
            int sum = 0;
            foreach (int i in array)
            {
                sum += i;
            }
            return sum;
        }

        static int ArraySumTwist(int[] array)
        {
            int sum = 0;
            foreach (int i in array)
            {
                sum += i > 10 ? i : 0;
            }
            return sum;
        }

        static int ArraySumTwist2(int[] array)
        {
            return array.Select(i => i > 10 ? i : 0).Sum();
        }

        static int ListCount(string[] array)
        {
            int sum = 0;
            foreach (string s in array)
            {
                sum += s.StartsWith("D") ? 1 : 0;
            }
            return sum;
        }

        static int ListCount2(string[] array)
        {
            return array.Select(s => s.StartsWith("D") ? 1 : 0).Count();
        }

        static void SetInsert(HashSet<int> mySet, int maxVal)
        {
            int i = 1;
            while(SetSum(mySet)<=maxVal)
            {
                mySet.Add(i++);
            }
        }

        static int SetSum(HashSet<int> mySet)
        {
            int sum = 0;
            foreach (int i in mySet)
            {
                sum += i;
            }
            return sum;
        }


    }
}
