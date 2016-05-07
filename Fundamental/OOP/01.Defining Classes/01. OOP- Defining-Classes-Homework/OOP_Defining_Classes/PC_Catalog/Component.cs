using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 public class Component
    {

    private string name;
    private string details;
    private decimal price;

    public Component(string name, decimal price)
    {
        this.Name = name;
        this.Price = price;

    }

    public Component (string name, decimal price, string details) : this(name, price)
    {
        this.Details = details;

    }

    public string Name
    {
        get
        {
            return name;
        }

        set
        {
            if(string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Name cannot be empty");
            }
            name = value;
        }
    }

    public string Details
    {
        get
        {
            return details;
        }

        set
        {
            if (string.IsNullOrEmpty(value))
            {
                details = "No details available";
            }
            else
            {
                details = value;
            }
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
            if(value < 0)
            {
                throw new ArgumentNullException("Price should be more than ZERO");
            }
            price = value;
        }
    }
    public override string ToString()
    {
        return String.Format("Component Name: {0}, Price: {1}, Details: {2}", this.name, this.price, this.details);
    }
}

