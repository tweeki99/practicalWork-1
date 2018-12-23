using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int lowNumber = 5;
            long bigNumber = lowNumber;
            lowNumber = (int)bigNumber;

            Console.WriteLine("Первое задание");

            string myName = "Шипилов Данил";
            Console.WriteLine(myName);



            Console.WriteLine();
            Console.WriteLine("Второе задание");


            int firstNumber, secondNumber, sum;
            firstNumber = int.Parse(Console.ReadLine());
            secondNumber = int.Parse(Console.ReadLine());
            sum = firstNumber + secondNumber;
            Console.WriteLine(sum);



            Console.ReadKey();

        }
    }
}
