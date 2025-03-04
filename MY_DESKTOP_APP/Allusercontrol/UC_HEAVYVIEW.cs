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

            
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                
                LinkedList vehicleList = ListManager.GetVehicleList();

               
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Name", typeof(string));
                dataTable.Columns.Add("Quantity", typeof(int));
                dataTable.Columns.Add("Year", typeof(int));
                dataTable.Columns.Add("Price", typeof(double));

                
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

                
                dataview.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
          
            Form parentForm = this.FindForm();
            if (parentForm != null)
            {
                parentForm.Close();
            }
            
        }


        private void btnsortyear_Click(object sender, EventArgs e)
        {
            try
            {

                LinkedList originalList = ListManager.GetVehicleList();

                
                Node[] nodesArray = new Node[originalList.Count];

                
                Node current = originalList.Head;
                int index = 0;
                while (current != null)
                {
                    nodesArray[index++] = current;
                    current = current.Next;
                }

                // Sorting vehicles using their year on merge sort
                MergeSort(nodesArray, 0, nodesArray.Length - 1);

                
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Name", typeof(string));
                dataTable.Columns.Add("Quantity", typeof(int));
                dataTable.Columns.Add("Year", typeof(int));
                dataTable.Columns.Add("Price", typeof(double));

                
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

                
                dataview.DataSource = dataTable;

                MessageBox.Show("Data sorted by year in ascending order.", "Sort Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sorting data: " + ex.Message, "Sort Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Merge Sort Algorithm-Avishka's work
        private void MergeSort(Node[] arr, int left, int right)
        {
            if (left < right)
            {
               
                int middle = (left + right) / 2;

                
                MergeSort(arr, left, middle);
                MergeSort(arr, middle + 1, right);

                
                Merge(arr, left, middle, right);
            }
        }

        private void Merge(Node[] arr, int left, int middle, int right)
        {
            
            int n1 = middle - left + 1;
            int n2 = right - middle;

           
            Node[] leftArray = new Node[n1];
            Node[] rightArray = new Node[n2];

           
            for (int i = 0; i < n1; ++i)
                leftArray[i] = arr[left + i];

            for (int j = 0; j < n2; ++j)
                rightArray[j] = arr[middle + 1 + j];

            
            int i2 = 0, j2 = 0;
            
            int k = left;

            while (i2 < n1 && j2 < n2)
            {
              
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

            while (i2 < n1)
            {
                arr[k] = leftArray[i2];
                i2++;
                k++;
            }

        
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