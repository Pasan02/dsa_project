using System;
using System.Windows.Forms;
using Node1;
using LinkedList1;
using System.Data;

namespace MY_DESKTOP_APP.Allusercontrol
{
    public partial class UC_HEAVYVIEW : UserControl
    {
        public UC_HEAVYVIEW()
        {
            InitializeComponent();

            // Load the data when the control is initialized
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                // Get the vehicle list from the ListManager
                LinkedList vehicleList = ListManager.GetVehicleList();

                // Create a DataTable to bind to the DataGridView
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Name", typeof(string));
                dataTable.Columns.Add("Quantity", typeof(int));
                dataTable.Columns.Add("Year", typeof(int));
                dataTable.Columns.Add("Price", typeof(double));

                // Traverse the linked list and add each vehicle to the DataTable
                Node current = vehicleList.Head;
                while (current != null)
                {
                    Vehicle vehicle = current.data;
                    dataTable.Rows.Add(
                        vehicle.GetName(),
                        vehicle.GetQuantity(),
                        vehicle.GetYear(),
                        vehicle.GetPrice()
                    );
                    current = current.Next;
                }

                // Bind the DataTable to the DataGridView
                dataview.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            // Close the parent form (which will trigger the FormClosed event)
            Form parentForm = this.FindForm();
            if (parentForm != null)
            {
                parentForm.Close();
            }
            // Form1 will be shown automatically due to the FormClosed event handler
        }

        private void dataview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // You can implement additional functionality here if needed
        }

        private void btnsortyear_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the vehicle list from the ListManager
                LinkedList originalList = ListManager.GetVehicleList();

                // Create a temporary array to store the nodes for sorting
                Node[] nodesArray = new Node[originalList.Count];

                // Copy all nodes to the array
                Node current = originalList.Head;
                int index = 0;
                while (current != null)
                {
                    nodesArray[index++] = current;
                    current = current.Next;
                }

                // Sort the array using merge sort
                MergeSort(nodesArray, 0, nodesArray.Length - 1);

                // Now create a DataTable with the sorted data
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Name", typeof(string));
                dataTable.Columns.Add("Quantity", typeof(int));
                dataTable.Columns.Add("Year", typeof(int));
                dataTable.Columns.Add("Price", typeof(double));

                // Add the sorted nodes to the DataTable
                foreach (Node node in nodesArray)
                {
                    Vehicle vehicle = node.data;
                    dataTable.Rows.Add(
                        vehicle.GetName(),
                        vehicle.GetQuantity(),
                        vehicle.GetYear(),
                        vehicle.GetPrice()
                    );
                }

                // Update the DataGridView with the sorted data
                dataview.DataSource = dataTable;

                MessageBox.Show("Data sorted by year in ascending order.", "Sort Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sorting data: " + ex.Message, "Sort Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Merge sort implementation for nodes based on vehicle year
        private void MergeSort(Node[] arr, int left, int right)
        {
            if (left < right)
            {
                // Find the middle point
                int middle = (left + right) / 2;

                // Sort first and second halves
                MergeSort(arr, left, middle);
                MergeSort(arr, middle + 1, right);

                // Merge the sorted halves
                Merge(arr, left, middle, right);
            }
        }

        private void Merge(Node[] arr, int left, int middle, int right)
        {
            // Find sizes of two subarrays to be merged
            int n1 = middle - left + 1;
            int n2 = right - middle;

            // Create temp arrays
            Node[] leftArray = new Node[n1];
            Node[] rightArray = new Node[n2];

            // Copy data to temp arrays
            for (int i = 0; i < n1; ++i)
                leftArray[i] = arr[left + i];

            for (int j = 0; j < n2; ++j)
                rightArray[j] = arr[middle + 1 + j];

            // Merge the temp arrays
            // Initial indexes of first and second subarrays
            int i2 = 0, j2 = 0;
            // Initial index of merged subarray
            int k = left;

            while (i2 < n1 && j2 < n2)
            {
                // Compare by vehicle year
                if (leftArray[i2].data.GetYear() <= rightArray[j2].data.GetYear())
                {
                    arr[k] = leftArray[i2];
                    i2++;
                }
                else
                {
                    arr[k] = rightArray[j2];
                    j2++;
                }
                k++;
            }

            // Copy remaining elements of leftArray[] if any
            while (i2 < n1)
            {
                arr[k] = leftArray[i2];
                i2++;
                k++;
            }

            // Copy remaining elements of rightArray[] if any
            while (j2 < n2)
            {
                arr[k] = rightArray[j2];
                j2++;
                k++;
            }
        }

        private void btnsetdefault_Click(object sender, EventArgs e)
        {
            try
            {
                // Simply reload the data from the original list
                LoadData();

                MessageBox.Show("Data restored to original order.", "Default Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error restoring data: " + ex.Message, "Restore Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}