using System;

namespace task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = Convert.ToDouble(Console.ReadLine());
            string b = Console.ReadLine();
           double num2 = Convert.ToDouble(b);
            Divise(num1, num2);
            Console.WriteLine(Divise(num1,num2));
            Vurma(num1, num2);
            Console.WriteLine(Vurma(num1, num2)); ;

        }
        static double Divise(double num1, double num2)
        {
            return num1 / num2; 
        }
        static double Vurma(double num1, double num2)
        {
            return num1 * num2;
        }
           
    }
}
