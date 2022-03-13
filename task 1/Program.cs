using System;

namespace task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1
            double num1 = Convert.ToDouble(Console.ReadLine());
            string b = Console.ReadLine();
            double num2 = Convert.ToDouble(b);
            Divise(num1, num2);
            Console.WriteLine(Divise(num1, num2));
            Vurma(num1, num2);
            Console.WriteLine(Vurma(num1, num2));
            #endregion
            #region task2
            string word = "happiness";
            int count = 5;
            Console.WriteLine(Repeat(word, count));


        }
        static double Divise(double num1, double num2)
        {
            return num1 / num2;
        }
        static double Vurma(double num1, double num2)
        {
            return num1 * num2;
        }
        static string Repeat(string word, int count)
        {
            string result = word;
            while (count > 1)
            {
                result += word;
                count--;
            }
            return result;
        }

        #endregion



    }
}
