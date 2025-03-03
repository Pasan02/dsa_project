using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_DESKTOP_APP
{
    public class Vehicle
    {
        private string name;
        private int quantity;
        private int production_date;
        private Double price;

        public Vehicle(String name,int quantity,int year,double price)
        {
            this.production_date = year;
            this.price = price;
            this.quantity = quantity;
            this.name = name;
        }
        public void SetName(String name)
        {
            this.name = name;

        }
        public String GetName()
        {
            return name;

        }

        public void SetQuantity(int quantity)
        {
            this.quantity = quantity;

        }
        public int GetQuantity()
        {
            return quantity;

        }

        public void SetYear(int year)
        {
            this.production_date = year;

        }
        public int GetYear()
        {
            return production_date;

        }

        public void SetPrice(int quantity)
        {
            this.price = price;

        }
        public Double GetPrice()
        {
            return price;

        }
    }

   
}
