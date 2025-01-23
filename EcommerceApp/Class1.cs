using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApp
{

    public class productClass
    {
        public productClass() { }
        List<productClass> products;
        
        int id;
        string name;
        double price;
        Image image;
        string description;
        int amount;

        public productClass(int id, string name, double price, Image image, string description, int amount)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.image = image;
            this.description = description;
            this.amount = amount;   
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public Image Image
        {
            get { return image; }
            set { image = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }
    }
}
