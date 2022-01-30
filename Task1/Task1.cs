using System;

namespace QE_Tasks
{
    class Task1
    {
        static void Main(string[] args)
        {
            int n;
            string s = Console.ReadLine();
            Int32.TryParse(s, out n);
            int[] array = new int[1000];
            for (int i = 0; i < 1000; i++)
            {
                array[i] = 1;
            }
            for (int i = 2; i < 1000; i++)
            {
                if (array[i] == 1)
                {
                    for (int j = i * i; j < 1000; j += i)
                    {
                        array[j] = 0;
                    }
                }
            }
            int sum = 0;
            for (int i = 2; i < 1000; i++)
            {
                if (array[i] == 1)
                {
                    sum += i;
                }
                if (sum > n)
                {
                    sum -= i;
                    break;
                }
                Console.WriteLine(array[i]);
            }
            Console.WriteLine(sum);
        }
    }
}
