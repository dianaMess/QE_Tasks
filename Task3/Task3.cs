using System;
using System.Collections.Generic;

namespace Task3
{
    class Task3
    {
        static void Main(string[] args)
        {
            int n, tmp;
            string s = Console.ReadLine();
            Int32.TryParse(s, out n);
            List<int> a = new List<int>();
            List<int> pairs = new List<int>();
            for (int i = 0; i < n; i++)
            {
                s = Console.ReadLine();
                Int32.TryParse(s, out tmp);
                a.Add(tmp);
            }
            a.Sort();
            int j = 0;
            while(j < n)
            {
                if ((j + 1) == n)
                {
                    pairs.Add(a[j]);
                    break;
                }
                if((Math.Abs(a[j] - a[j + 1]) == 0) || (Math.Abs(a[j] - a[j + 1]) == 1))
                {
                    pairs.Add(a[j]);
                    j += 2;
                } else if (Math.Abs(a[j] - a[j + 1]) == 2)
                {
                    pairs.Add((a[j] + a[j + 1]) / 2);
                    j += 2;
                } else
                {
                    pairs.Add(a[j]);
                    j += 1;
                }

            }
            for (int i = 0; i < pairs.Count; i++)
            {
                Console.WriteLine("Одна пара в {0} диоптрий", pairs[i]);
            }
        }
    }
}
