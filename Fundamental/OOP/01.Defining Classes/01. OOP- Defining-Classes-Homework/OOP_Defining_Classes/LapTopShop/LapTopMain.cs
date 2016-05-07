using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTopShop
{
    class LapTopMain
    {
        static void Main()
        {
            Battery myBattery = new Battery(TypesOfBattery.NiMh, 3.30, 6, 5760.00);
            Battery myBattery1 = new Battery();

            Laptop myLaptopHP = new Laptop("HP EliteBook", 1820);
            Laptop myLaptopLenovo = new Laptop("Lenovo ThinkPad", (decimal)950.30, myBattery);
            Laptop myLaptopApple = new Laptop("Apple McBook", (decimal)3600.99, myBattery1, "Apple", "Intel Core i7 6 series", 8, "NVidia GForce 4", "Solid State 512 GB", "IPS Anti-Glare Screen");

            Console.WriteLine(myLaptopHP + Environment.NewLine);
            Console.WriteLine(myLaptopLenovo + Environment.NewLine);
            Console.WriteLine(myLaptopApple + Environment.NewLine);


        }
    }
}
