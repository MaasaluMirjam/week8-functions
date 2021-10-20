using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta esimene number");
            int firstnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sisesta teine number");
            int secondnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vali tehe ('+', '-', '*', '/'");
            char userOperator = Convert.ToChar(Console.ReadLine());
            

            switch (userOperator)
            {
                case '+':
                    AddTwoNumbers(firstnumber, secondnumber);
                    break;

                case '/':
                    DivideTwoNumbers(firstnumber, secondnumber);
                    break;

                case '-':
                    SubtractTwoNumbers(firstnumber, secondnumber);
                    break;

                case '*':
                    MultiplyTwoNumbers(firstnumber, secondnumber);
                    break;

                default:
                    Console.WriteLine("Vale tehe");
                    break;
            }

        }

        private static void AddTwoNumbers(int x, int y)
        {
            int result = x + y;
            Console.WriteLine($"{x} + {y} = {result}");
        }

        private static void DivideTwoNumbers(double x, double y)
        {
            double result = x / y;
            Console.WriteLine($"{x} / {y} = {result}");
        }

        private static void MultiplyTwoNumbers(double x, double y)
        {
            double result = x * y;
            Console.WriteLine($"{x} * {y} = {result}");
        }

        private static void SubtractTwoNumbers(double x, double y)
        {
            double result = x - y;
            Console.WriteLine($"{x} - {y} = {result}");
        }

    }
}
