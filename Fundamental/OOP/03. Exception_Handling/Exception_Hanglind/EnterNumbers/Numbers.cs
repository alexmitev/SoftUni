﻿using System;

//Problem 2.	Enter Numbers
//Write a method ReadNumber(int start, int end) that enters an integer number in given range[start…end]. If an invalid number or non-number text is entered, the method should throw an exception.Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1< … < a10< 100. If the user enters an invalid number, let the user to enter again.


namespace EnterNumbers
{

    class Numbers
    {
        private static void ReadNumber(int start, int end, int num)
        {
            if(num < start || num > end)
            {
                ThrowException();
            }
            Console.WriteLine("Successful entry");
        }

        private static void ThrowException()
        {
            throw new ArgumentOutOfRangeException();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter begining and end numbers of the range");
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                int num;
                try
                {   
                    Console.WriteLine("Please enter a number");
                     num = int.Parse(Console.ReadLine());
                    ReadNumber(start, end, num);
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Please enter a valid number");
                     num = int.Parse(Console.ReadLine());
                    ReadNumber(start, end, num);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter do not enter anything else, but a valid integer");
                    num = int.Parse(Console.ReadLine());
                    ReadNumber(start, end, num);
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter do not enter anything else, but a valid integer");
                    num = int.Parse(Console.ReadLine());
                    ReadNumber(start, end, num);
                }
            }
           

        }
    }
  
}
