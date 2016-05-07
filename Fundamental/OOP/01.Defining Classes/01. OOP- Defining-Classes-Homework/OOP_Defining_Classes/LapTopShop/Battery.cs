using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTopShop
{
    public class Battery
    {
        private string batteryType;   
        private double batteryLife;
        private int cells;
        private double capacity;

        public Battery() : this(TypesOfBattery.LiIon, 3.00, 4, 1000.00)
        {

        }

        public Battery (TypesOfBattery batteryType, double batteryLife, int cells, double capacity)
        {
            this.SetBatteryType(batteryType);
            this.batteryLife = batteryLife;
            this.Cells = cells;
            this.Capacity = capacity;

        }

        public double BatteryLife
        {
            get
            {
                return batteryLife;
            }

            set
            {
                if(value < 1)
                {
                    throw new ArgumentOutOfRangeException("Battery life cannot be less than 1");
                }

                batteryLife = value;
            }
        }

        public double Capacity
        {
            get
            {
                return capacity;
            }

            set
            {
                if(value < 100 | value > 10000)
                {
                    throw new ArgumentOutOfRangeException ( "Capacity must be between 100 and 10000 mah." );
                }
                capacity = value;
            }
        }

        public int Cells
        {
            get
            {
                return cells;
            }

            set
            {
                if(value < 4 | value > 8)
                {
                    throw new ArgumentOutOfRangeException("Cell must be in the range between 4 and 8");
                }
                cells = value;
            }
        }

        public string BatteryType
        {
           get
            {
                return batteryType;
            }

          private  set
            {
                batteryType = value;
            }
        }
        public void SetBatteryType(TypesOfBattery typeBattery)
        {
            if ((int)typeBattery == 0)
            {
                this.BatteryType = "Li-Ion";
            }
            else
            {
                this.BatteryType = "Ni-Mh";
            }

        }

        public override string ToString()
        {
            return string.Format("Battery - Type:{0, 7}, Cells:{1, 3}, Capacity:{2, 6} Mah, Life:{3, 5} hours", this.batteryType, this.cells, this.capacity, this.batteryLife.ToString("F"));
        }
    }
}
