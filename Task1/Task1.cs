using System;

namespace QE_Tasks
{
    class Task1
    {
        static void Main(string[] args)
        {
            int n = 15;
            int[] array = new int[n];
            array[0] = 0;
            array[1] = 0;
            for (int i = 0; i < n; i++)
            {
                array[i] = 1;
            }
            for (int i = 2; i * i < n; i++)
            {
                if (array[i] == 1)
                {
                    for (int j = i * i; j < n; j++)
                    {
                        array[j] = 0;
                    }
                }
            }
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] == 1)
                {
                    sum += array[i];
                }
                if (sum > n)
                {
                    break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
