using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class OperatorsWithSwitch
    {
        static void Main()
        {
            Console.WriteLine("Enter The First Number:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter The Second Number:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 1/2/3/4/5:");
            int i = int.Parse(Console.ReadLine());
            switch(i)
            {
                case 1:
                    Console.WriteLine("The Value is:" +(a+b));
                    break;

                case 2:
                    Console.WriteLine("The Value is:" + (a - b));
                    break;

                case 3:
                    Console.WriteLine("The Value is:" + (a * b));
                    break;

                case 4:
                    Console.WriteLine("The Value is:" + (a / b));
                    break;

                case 5:
                    Console.WriteLine("The Value is:" + (a % b));
                    break;

                default:
                    Console.WriteLine("None of the above:");
                    break;
            }
            Console.ReadLine();
        }
    }
}
