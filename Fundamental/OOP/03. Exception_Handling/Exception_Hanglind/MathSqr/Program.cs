using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathSqr
{
    class Program
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
