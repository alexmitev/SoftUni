using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class PC_Catalog_Main

    {
        static void Main(string[] args)
        {
        Component screen = new Component("Screen", (decimal)250.50, "Full HD, anti-glare");
        Component screen1 = new Component("Screen", (decimal)200.50);
        Component screen2 = new Component("Screen", (decimal)370, "QHD Matte touch screen");

        Component hdd = new Component("Hard Disk", (decimal)100.00);
        Component hdd1 = new Component("Hard Disk", (decimal)150.80, "1TB Standard Hard Drive");
        Component hdd2 = new Component("Hard Disk", (decimal)370, "SSD 256 GB");

        Component processor = new Component("Intel Pro", (decimal)640);
        Component processor1 = new Component("AMD Processor", (decimal)530.80, "Quad-Core 2.3 Mghz");
        Component processor2 = new Component("Intel i7", (decimal)1270.13, "i7 Q6700 Octa-Core");

        Computer hp = new Computer("HP EliteBook", new List<Component> { screen, hdd, processor });
        Computer hp1 = new Computer("HP ProBook 6400", new List<Component> { screen1, hdd1, processor1 });
        Computer lenovo = new Computer("Lenovo ThinkPad", new List<Component> { screen2, hdd2, processor2 });
        Computer apple = new Computer(
            "Mcbook 2016",
            new List<Component> {
                new Component("Screen", 1899.80m, "QHD Touch Matte anti-glare"),
                new Component("Hard Disk", 515m, "Solid state 512 GB"),
                new Component("Intel i7 Pro", 1144.20m, "Intel i7 q6700 Pro")
            }
            );

        List<Computer> pc_catalog = new List<Computer>() { hp, hp1, lenovo, apple };

        foreach (var comp in pc_catalog)
        {
            Console.WriteLine(comp.Name);
            comp.PrintComponents();
        }
        Console.WriteLine();
        var sortedCatalog =
        from computer in pc_catalog
     
        orderby computer.Price
        select computer;

        foreach (var comp in sortedCatalog)
        {
            Console.WriteLine(comp.Name);
            comp.PrintComponents();
        }







    }
    }

