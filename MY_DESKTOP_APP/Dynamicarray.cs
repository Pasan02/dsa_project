using MY_DESKTOP_APP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Dynamic Array Implementation-Upeka's Work5
namespace dyanamic
{
    public class Dynamic_Array
    {
        public int capacity;
        public Vehiclepart[] arr;
        public int counter;

        public Dynamic_Array()
        {
            capacity = 5;
            arr = new Vehiclepart[capacity];
            counter = 0;
        }

        public int Add(Vehiclepart part)
        {
            int added = 0;
            if (counter < capacity)
            {
                arr[counter] = part;
                counter++;
                ++added;
            }
            else
            {
                capacity *= 2;
                Vehiclepart[] temp = new Vehiclepart[capacity];
                for (int i = 0; i < counter; i++)
                {
                    temp[i] = arr[i];
                }
                temp[counter] = part;
                arr = temp;
                counter++;
                ++added;
            }
            return added;
        }

        public void print()
        {
            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public bool isAvailable(Vehiclepart part)
        {
            int count = 0;
            for (int i = 0; i < counter; i++)
            {
                if (arr[i] != null &&
                    arr[i].Name == part.Name &&
                    arr[i].Quantity == part.Quantity &&
                    arr[i].Price == part.Price)
                {
                    count++;
                }
            }
            return count >= 1;
        }

        public int position(Vehiclepart part)
        {
            int pos = -1;
            for (int i = 0; i < counter; i++)
            {
                if (arr[i] != null &&
                    arr[i].Name == part.Name &&
                    arr[i].Quantity == part.Quantity &&
                    arr[i].Price == part.Price)
                {
                    pos = i;
                    break;
                }
            }
            return pos;
        }

        public void remove(Vehiclepart part)
        {
            int pos = position(part);
            if (pos != -1)
            {
                for (int j = pos; j < counter - 1; j++)
                {
                    arr[j] = arr[j + 1];
                }
                counter--;
            }
        }
    }
}