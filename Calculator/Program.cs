using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum;
            double secondNum;
            double answer;
            string ops;

            Console.WriteLine("Console Calculator\r");
            Console.WriteLine("------------------\r");

            Console.WriteLine("Select an Operator: ( + , - , * , / )");
            ops = Console.ReadLine();

            Console.WriteLine("\nEnter first number\n");
            firstNum = Double.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter second number\n");
            secondNum = Double.Parse(Console.ReadLine());

            if (ops == "+")
            {
                answer = firstNum + secondNum;
                Console.WriteLine(answer);
            }

            if (ops == "-")
            {
                answer = firstNum - secondNum;
                Console.WriteLine(answer);
            }

            if (ops == "*")
            {
                answer = firstNum * secondNum;
                Console.WriteLine(answer);
            }

            if (ops == "/")
            {
                answer = firstNum / secondNum;
                Console.WriteLine(answer);
            }

            Console.Write("\nPress any key to exit...");
            Console.ReadLine();
        }
    }
}
