using System;
using System.Text;


namespace Assignment3._1._1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(GetEvenNumbers());

        }

        static string GetEvenNumbers()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 2; i < 100; i += 2)
            {
                sb.Append(i + " ");
            }
            return
                sb.ToString();
        }
    }
}