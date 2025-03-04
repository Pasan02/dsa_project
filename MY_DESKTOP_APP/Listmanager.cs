
using LinkedList1;
using System;
using System.Collections.Generic;

namespace MY_DESKTOP_APP
{
    
    public static class ListManager
    {
       
        private static LinkedList vehicleList = new LinkedList();

        
        public static int AddVehicle(Vehicle vehicle)
        {
            return vehicleList.AddEnd(vehicle);
        }

        
        public static LinkedList GetVehicleList()
        {
            return vehicleList;
        }
    }
}