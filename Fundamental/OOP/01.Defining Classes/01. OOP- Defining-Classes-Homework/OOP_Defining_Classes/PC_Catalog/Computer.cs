using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Computer
{
    private string name;

    private decimal price;
    private List<Component> components;

    public Computer (string name, List<Component> comps)
    {
        this.Name = name;
        this.Components = comps;
        this.Price = CalcPrice(this.Components);
    }


    public string Name
    {
        get
        {
            return name;
        }

        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Name cannot be empty");
            }
            name = value;
        }
    }

    public List<Component> Components
    {
        get
        {
            return components;
        }

        set
        {
            if (value.Count < 3)
            {
                throw new ArgumentException("Compenents count must be at least 3 individual components");
            }
            components = value;
        }
    }


    public decimal Price
    {
        get
        {
            return price;
        }

        private set
        {
            price = value;

        }

    }
        private decimal CalcPrice(List<Component> comps)
    {
        decimal sum = 0m;
        foreach (var component in comps)
        {
            sum += component.Price;
        }
        return sum;
    }
    public override string ToString()
    {
        StringBuilder str = new StringBuilder(this.name);

        foreach (var item in this.components)
        {
            str.AppendFormat("\n{0}", item.ToString());
        }

        return str.ToString();
    }
    public void PrintComponents()
    {
        StringBuilder toPrint = new StringBuilder();

        foreach (var item in this.components)
        {
            toPrint.Append(item.ToString() + "\n");
        }
        toPrint.Append("Computer price:" + this.Price + "\n");
        Console.WriteLine(toPrint.ToString());
    }
}


