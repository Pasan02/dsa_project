using System;

namespace MY_DESKTOP_APP
{
    public class Vehiclepart
    {
        private string name;
        private int quantity;
        private double price;

        // Constructor with all arguments
        public Vehiclepart(string name, int quantity, double price)
        {
            this.name = name;
            this.quantity = quantity;
            this.price = price;
        }

        // Getter and Setter for Name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Getter and Setter for Quantity
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        // Getter and Setter for Price
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}