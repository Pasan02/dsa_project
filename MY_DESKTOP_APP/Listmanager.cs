// Add this to a new file called ListManager.cs in your project
using LinkedList1;
using System;
using System.Collections.Generic;

namespace MY_DESKTOP_APP
{
    // Static class to hold the linked list so it can be accessed from multiple forms
    public static class ListManager
    {
        // Static instance of LinkedList to store vehicle data across the application
        private static LinkedList vehicleList = new LinkedList();

        // Method to add a vehicle to the list
        public static int AddVehicle(Vehicle vehicle)
        {
            return vehicleList.AddEnd(vehicle);
        }

        // Method to get the list
        public static LinkedList GetVehicleList()
        {
            return vehicleList;
        }
    }
}