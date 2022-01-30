using System;

namespace Task2
{
    class Task2
    {
        static void Main(string[] args)
        {
            int[] nominals = { 1, 2, 5, 10, 50, 100, 200, 500, 1000, 2000, 5000 };
            int[] nominals_count = new int[11];
            int size = nominals.Length;
            int sum, given_money;
            string s = Console.ReadLine();
            Int32.TryParse(s, out sum);
            s = Console.ReadLine();
            Int32.TryParse(s, out given_money);
            sum = given_money - sum;
            for (int i = size - 1; i >= 0; i--)
            {
                while (sum <= nominals[i])
                {
                    sum -= nominals[i];
                    nominals_count[i]++;
                }
            }
        }
    }
}
