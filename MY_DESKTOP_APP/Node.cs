using MY_DESKTOP_APP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Node1
{
    public class Node
    {
        public Vehicle data { get; set; }
        public Node? Next { get; set; }

        public Node(Vehicle vehicle1)
        {
            data = vehicle1;
            Next = null;
        }
    }
}
