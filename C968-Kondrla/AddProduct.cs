using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968_Kondrla
{
    public partial class AddProduct : Form
    {
        BindingList<Part> addedParts = new BindingList<Part>();

        public AddProduct()
        {
            InitializeComponent();

            // Populate top DataGridView with all parts
            candidateDataGrid.DataSource = Inventory.AllParts;

            // Set up bottom DataGridView for added parts
            associatedDataGrid.DataSource = addedParts;

            // Configure DataGridViews
            ConfigureDataGridView(candidateDataGrid);
            ConfigureDataGridView(associatedDataGrid);

            // Load new product ID
            textIDProduct.Text = (Inventory.Products.Count + 1).ToString();
        }

        // Configure DataGridView settings
        private void ConfigureDataGridView(DataGridView dataGridView)
        {
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.ReadOnly = true;
            dataGridView.MultiSelect = false;
            dataGridView.AllowUserToAddRows = false;
        }

        // Add candidate part
        private void btnCandidateAdd_Click(object sender, EventArgs e)
        {
            Part addedPart = (Part)candidateDataGrid.CurrentRow.DataBoundItem;

            // Check if the part is already added to the list
            if (addedParts.Contains(addedPart))
            {
                MessageBox.Show("This part is already added to the product.");
                return;
            }

            // Add the part to the list of added parts
            addedParts.Add(addedPart);

            // Clear the selection in both DataGridViews
            candidateDataGrid.ClearSelection();
            associatedDataGrid.ClearSelection();
        }

        // Save product
        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            // Declare Variables
            string name = textNameProduct.Text;
            int inventory, min, max;
            decimal price;

            // Parse input values
            bool isInventoryValid = int.TryParse(textInventoryProduct.Text, out inventory);
            bool isMinValid = int.TryParse(textMinProduct.Text, out min);
            bool isMaxValid = int.TryParse(textMaxProduct.Text, out max);
            bool isPriceValid = decimal.TryParse(textPriceProduct.Text, out price);

            // Check input fields
            if (!isInventoryValid)
            {
                MessageBox.Show("Error! Inventory must be a valid number.");
                return;
            }

            if (inventory < 0)
            {
                MessageBox.Show("Error! Inventory cannot be a negative number.");
                return;
            }

            if (!isMinValid)
            {
                MessageBox.Show("Error! Min must be a valid number.");
                return;
            }

            if (min < 0)
            {
                MessageBox.Show("Error! Min cannot be a negative number.");
                return;
            }

            if (!isMaxValid)
            {
                MessageBox.Show("Error! Max must be a valid number.");
                return;
            }

            if (max < 0)
            {
                MessageBox.Show("Error! Max cannot be a negative number.");
                return;
            }

            if (!isPriceValid)
            {
                MessageBox.Show("Error! Price must be a valid decimal number.");
                return;
            }

            if (price < 0)
            {
                MessageBox.Show("Error! Price cannot be a negative number.");
                return;
            }


            // Additional validations
            if (min > max)
            {
                MessageBox.Show("Error! Min cannot be greater than Max.");
                return;
            }

            if (inventory > max || inventory < min)
            {
                MessageBox.Show("Error! Inventory must be between Max and Min inventory.");
                return;
            }

            // Create and add product
            Product product = new Product(name, inventory, price, max, min);
            Inventory.AddProduct(product);

            // Add associated parts
            foreach (Part part in addedParts)
            {
                product.AddAssociatedPart(part);
            }

            // Close form
            Close();
        }

        // Delete associated part
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in associatedDataGrid.SelectedRows)
                {
                    associatedDataGrid.Rows.RemoveAt(row.Index);
                }
            }
        }

        // Cancel
        private void btnCancelProduct_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Search
        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            string searchTerm = searchTextBox.Text.Trim();

            // If the input is a valid part ID
            if (int.TryParse(searchTerm, out int targetPartID))
            {
                Part matchByID = Inventory.LookupPart(targetPartID);
                if (matchByID != null)
                {
                    foreach (DataGridViewRow row in candidateDataGrid.Rows)
                    {
                        Part part = (Part)row.DataBoundItem;
                        if (part.PartID == targetPartID)
                        {
                            row.Selected = true;

                            candidateDataGrid.FirstDisplayedScrollingRowIndex = row.Index;
                            candidateDataGrid.CurrentCell = row.Cells[0]; // Select the cell
                            return;
                        }
                    }
                }
                MessageBox.Show($"Cannot find part with ID '{targetPartID}'.");
            }
            else // If the input is not a valid part ID, search by part name
            {
                Part matchByName = Inventory.AllParts.FirstOrDefault(part => part.Name.Equals(searchTerm, StringComparison.OrdinalIgnoreCase));
                if (matchByName != null)
                {
                    foreach (DataGridViewRow row in candidateDataGrid.Rows)
                    {
                        Part part = (Part)row.DataBoundItem;
                        if (part.Name.Equals(searchTerm, StringComparison.OrdinalIgnoreCase))
                        {
                            row.Selected = true;

                            candidateDataGrid.FirstDisplayedScrollingRowIndex = row.Index;
                            candidateDataGrid.CurrentCell = row.Cells[0]; // Select the cell
                            return;
                        }
                    }
                }
                MessageBox.Show($"Cannot find part with name '{searchTerm}'.");
            }
        }

        // Clear
        private void thisBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            candidateDataGrid.ClearSelection();
            associatedDataGrid.ClearSelection();
        }

        // Add Part Button Functionality
        private void btnAddPart_Click(object sender, EventArgs e)
        {
            // Open AddPart form to add new parts
            AddPart addPartForm = new AddPart();
            addPartForm.ShowDialog();

            // Refresh DataGridView after adding new parts
            candidateDataGrid.DataSource = Inventory.AllParts;
            ConfigureDataGridView(candidateDataGrid);
        }
    }
}
       
