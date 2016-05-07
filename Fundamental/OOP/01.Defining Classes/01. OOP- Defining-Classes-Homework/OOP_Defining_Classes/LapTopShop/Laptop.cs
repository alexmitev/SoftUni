using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Define a class Laptop that holds the following information about a laptop device: model, manufacturer, processor, RAM, graphics card,
//HDD, screen, battery, battery life in hours and price.


    
namespace LapTopShop
{
    public class Laptop
    {
        private string model; //mandatory
        private decimal price; //mandatory
        
        //Optional
        private string manifacturer;    //1
        private string processor;       //2
        private int ram;                //3
        private string  graphicsCard;   //4
        private Battery laptopBattery;  //5
        private string hdd;             //6
        private string screen;          //7

        public Laptop (string model, decimal price)
        {
            this.Model = model;
            this.Price = price;
        }

        public Laptop(string model, decimal price, Battery laptopBattery) 
            : this(model, price)
        {
            this.LaptopBattery = laptopBattery;
        }

        public Laptop(string model, decimal price, Battery laptopBattery, string manifacturer, string processor, int ram, string graphicsCard, string hdd, string screen)
             : this(model, price, laptopBattery)
        {
            this.Manifacturer = manifacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicsCard = graphicsCard;
            this.Hdd = hdd;
            this.Screen = screen;
        }
        public string Model
        {
            get
            {

                return model;
            }

            set
            {
                if (!isValidString(value))
                {

                    throw new ArgumentNullException("Model cannot be empty");
                }
                model = value;
            }
        }

        public decimal Price
        {
            get
            {
                return price;
            }

            set
            {
                if (!isValidNumber(value))
                {
                    throw new ArgumentException("Price cannot be a negative number");
                }
                price = value;
            }
        }

        public string Manifacturer
        {
            get
            {
                return manifacturer;
            }

            set
            {
                if(!isValidString (value))
                {
                    throw new ArgumentNullException("Manifacturer cannot be empty");
                }
                manifacturer = value;
            }
        }

        public string Processor
        {
            get
            {
                return processor;
            }

            set
            {
                if (!isValidString(value))
                {
                    throw new ArgumentNullException("Processor cannot be empty");
                }
                processor = value;
            }
        }

        public int Ram
        {
            get
            {
                return ram;
            }

            set
            {
                if (!isValidNumber((decimal)value))
                {
                    throw new ArgumentException("Ram cannot be a negative number");
                }
                ram = value;
            }
        }

        public string GraphicsCard
        {
            get
            {
                return graphicsCard;
            }

            set
            {
                if (!isValidString(value))
                {
                    throw new ArgumentNullException("Graphics Card cannot be empty");
                }
                graphicsCard = value;
            }
        }

        public Battery LaptopBattery
        {
            get
            {
               
                return laptopBattery;
            }

            set
            {
               
                laptopBattery = value;
            }
        }

        public string Hdd
        {
            get
            {
                return hdd;
            }

            set
            {
                if (!isValidString(value))
                {
                    throw new ArgumentNullException("HDD cannot be empty");
                }
                hdd = value;
            }
        }

        public string Screen
        {
            get
            {
                return screen;
            }

            set
            {
                if (!isValidString(value))
                {
                    throw new ArgumentNullException("Screen cannot be empty");
                }
                screen = value;
            }
        }

        private bool isValidString (string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }
            return true;
        }

        private bool isValidNumber(decimal number)
        {
            if (number < 0)
            {
                return false;
            }
            return true;
        }
        //public Laptop(string model, decimal price, Battery laptopBattery, string manifacturer, string processor, int ram, string graphicsCard, string hdd, string screen)
        public override string ToString()
        {

            StringBuilder laptopString = new StringBuilder();

            laptopString.AppendFormat("Model {0} \nPrice {1:F2} ", this.model, this.price);

            if (this.laptopBattery != null)
            {
                laptopString.AppendFormat("\n{0}",this.laptopBattery.ToString());
            }

            if(!string.IsNullOrEmpty(this.manifacturer))
            {
                laptopString.AppendFormat("\nManifacturer: {0}", this.manifacturer);
            }

            if (!string.IsNullOrEmpty(this.processor))
            {
                laptopString.AppendFormat("\nProcessor: {0}", this.processor);
            }

            if(this.ram > 0)
            {
                laptopString.AppendFormat("Ram: {0}", this.ram);
            }

            if (!string.IsNullOrEmpty(this.graphicsCard))
            {
                laptopString.AppendFormat("\nGraphics Card: {0}", this.graphicsCard);
            }

            if (!string.IsNullOrEmpty(this.screen))
            {
                laptopString.AppendFormat("\nScreen: {0}", this.screen);
            }

            return laptopString.ToString();
        }
    }
}
