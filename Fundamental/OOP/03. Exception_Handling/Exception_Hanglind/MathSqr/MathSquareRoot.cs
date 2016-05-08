using System;

//Problem 1.	Square Root
//Write a program that reads an integer number and calculates and prints its square root.If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye". Use try-catch-finally.



namespace MathSqr
{
    class MathSquareRoot
    {
        static void Main(string[] args)
        {

            try
            {
                
                int num = int.Parse(Console.ReadLine());
                if(num < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                Console.WriteLine(Math.Sqrt(num));
            }
            catch (ArgumentNullException )
            {
                Console.WriteLine("Number cannot be null");
            }
            catch (ArgumentOutOfRangeException )
            {
                Console.WriteLine("Invalid number");
            }
            catch   (ArgumentException )
            {
                Console.WriteLine("Invalid number");
            }
            catch(Exception )
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Goodbye");
            }
        }
    }
}
