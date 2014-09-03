using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            ChangeMaker(4.17);
            Console.ReadKey();
        }
       //create a function, ChangeMaker that takes a double parameter called amount
        static void ChangeMaker(double amount)
        {
           
            //declare variables for all amounts
            double hundreds = 0;
            double fifties = 0;
            double twenties = 0;
            double tens = 0;
            double fives = 0;
            double ones = 0;
            double quarters = 0;
            double dimes = 0;
            double nickels = 0;
            double pennies = 0;
            double leftover = 0;

            //round the amount to the nearest tenth
            leftover = Math.Round(amount, 2);

            //execute for $100
            hundreds = TotalNum(leftover, 100);
            leftover -= hundreds * 100;

            //execute for $50
            fifties = TotalNum(leftover, 50);
            leftover -= fifties * 50;

            //execute for $20
            twenties = TotalNum(leftover, 20);
            leftover -= twenties * 20;

            //execute for $10
            tens = TotalNum(leftover, 10);
            leftover -= tens * 10;

            //execute for $5
            fives = TotalNum(leftover, 5);
            leftover -= fives * 5;

            //execute for $1
            ones = TotalNum(leftover, 1);
            leftover -= ones * 1;

            //exceute for $0.25
            quarters = TotalNum(leftover, .25);
            leftover -= quarters * .25;

            //execute for $0.10
            dimes = TotalNum(leftover, .10);
            leftover -= dimes * .10;

            //execute for $0.05
            nickels = TotalNum(leftover, .05);
            leftover -= nickels * .05;

            //execute for $0.01
            pennies = TotalNum(leftover, .01);
            leftover -= pennies * .01;

            Console.WriteLine("Your change for " + Math.Round(amount, 2) + " is ");
            Console.WriteLine(hundreds + " $100's.");
            Console.WriteLine(fifties + " $50's.");
            Console.WriteLine(twenties + " $20's.");
            Console.WriteLine(tens + " $10's");
            Console.WriteLine(fives + " $5's.");
            Console.WriteLine(ones + " $1's.");
            Console.WriteLine(dimes + " dimes.");
            Console.WriteLine(nickels + " nickels.");
            Console.WriteLine(pennies + " pennies.");
        }

        //create a function to find how many times each amount goes into the total dollar amount
        static double TotalNum(double num, double total)
        {
            double number = 0;
            while ((number * total) < num - total)
            {
                number++;
            }

            return (number);
        }
    }
}
