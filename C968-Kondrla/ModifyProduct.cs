using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Internal;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968_Kondrla
{
    public partial class ModifyProduct : Form
    {
        BindingList<Part> addedParts = new BindingList<Part>();
        MainForm MainForm = (MainForm)Application.OpenForms["MainForm"];
        public ModifyProduct(Product prod)
        {
            InitializeComponent();
            textIDModify.Text = prod.ProductID.ToString();
            textNameModify.Text = prod.Name;
            textInventoryModify.Text = prod.InStock.ToString();
            textPriceModify.Text = prod.Price.ToString();
            textMaxModify.Text = prod.Max.ToString();
            textMinModify.Text = prod.Min.ToString();

            //adds to top data grid with all the parts
            candidateModifyGridView.DataSource = Inventory.AllParts;

            //adds to botton data grid with the added parts
            foreach (Part part in prod.AssociatedParts)
            { 
                addedParts.Add(part);
            }
            associatedModifyGridView.DataSource = addedParts;

            candidateModifyGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            associatedModifyGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //read only
            candidateModifyGridView.ReadOnly = true;
            associatedModifyGridView.ReadOnly = true;
            //don't allow added rows
            candidateModifyGridView.AllowUserToAddRows = false;
            associatedModifyGridView.AllowUserToAddRows = false;
            //don't select more than one row
            candidateModifyGridView.MultiSelect = false;
            associatedModifyGridView.MultiSelect = false;
        }

        //search
        private void btnSearchModifyProduct_Click(object sender, EventArgs e)
        {
            string searchTerm = textSearchModifyProduct.Text.Trim();

            // If the input is a valid part ID
            if (int.TryParse(searchTerm, out int targetPartID))
            {
                Part matchByID = Inventory.LookupPart(targetPartID);
                if (matchByID != null)
                {
                    foreach (DataGridViewRow row in candidateModifyGridView.Rows)
                    {
                        Part part = (Part)row.DataBoundItem;
                        if (part.PartID == targetPartID)
                        {
                            row.Selected = true;
                            
                            candidateModifyGridView.FirstDisplayedScrollingRowIndex = row.Index;
                            candidateModifyGridView.CurrentCell = row.Cells[0]; // Select the cell
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
                    foreach (DataGridViewRow row in candidateModifyGridView.Rows)
                    {
                        Part part = (Part)row.DataBoundItem;
                        if (part.Name.Equals(searchTerm, StringComparison.OrdinalIgnoreCase))
                        {
                            row.Selected = true;
                           
                            candidateModifyGridView.FirstDisplayedScrollingRowIndex = row.Index;
                            candidateModifyGridView.CurrentCell = row.Cells[0]; // Select the cell
                            return;
                        }
                    }
                }
                MessageBox.Show($"Cannot find part with name '{searchTerm}'.");
            }
        }    

        //add candidate part to associated part
        private void btnCandidateAddModify_Click(object sender, EventArgs e)
        {
            Part part = (Part)candidateModifyGridView.CurrentRow.DataBoundItem;

            // Check if the part already exists in the addedParts list
            if (!addedParts.Contains(part))
            {
                addedParts.Add(part);
            }
            else
            {
                MessageBox.Show("This part is already added.");
            }

            candidateModifyGridView.ClearSelection();
            associatedModifyGridView.ClearSelection();
        }

        //delete
        private void btnDeleteModify_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Part part = (Part)associatedModifyGridView.CurrentRow.DataBoundItem;
                int id = int.Parse(textIDModify.Text);

                Product product = Inventory.lookupProduct(id);
                product.RemoveAssociatedPart(part.PartID);

                foreach (DataGridViewRow row in associatedModifyGridView.SelectedRows)
                {
                    associatedModifyGridView.Rows.RemoveAt(row.Index);
                }
            }
            else return;
        }
        //save
        private void btnSaveModify_Click(object sender, EventArgs e)
        {
            // Validate input fields for numeric values
            if (!int.TryParse(textMinModify.Text, out int min))
            {
                MessageBox.Show("Error! Min must be a valid number.");
                return;
            }
            else if (min < 0)
            {
                MessageBox.Show("Error! Min cannot be a negative number.");
                return;
            }

            if (!int.TryParse(textMaxModify.Text, out int max))
            {
                MessageBox.Show("Error! Max must be a valid number.");
                return;
            }
            else if (max < 0)
            {
                MessageBox.Show("Error! Max cannot be a negative number.");
                return;
            }

            if (!int.TryParse(textInventoryModify.Text, out int inventory))
            {
                MessageBox.Show("Error! Inventory must be a valid number.");
                return;
            }
            else if (inventory < 0)
            {
                MessageBox.Show("Error! Inventory cannot be a negative number.");
                return;
            }

            if (!decimal.TryParse(textPriceModify.Text, out decimal price))
            {
                MessageBox.Show("Error! Price must be a valid decimal number.");
                return;
            }
            else if (price < 0)
            {
                MessageBox.Show("Error! Price cannot be a negative decimal number.");
                return;
            }

            // Convert other input fields
            int id = int.Parse(textIDModify.Text);
            string name = textNameModify.Text;

            // Check min and max constraints
            if (min > max)
            {
                MessageBox.Show("Error! Min cannot be greater than Max.");
                return;
            }

            if (inventory > max || inventory < min)
            {
                MessageBox.Show("Error! Inventory must be between Min and Max values.");
                return;
            }

            // Create new product and add associated parts
            Product product = new Product(name, inventory, price, max, min);
            foreach (Part part in addedParts)
            {
                product.AddAssociatedPart(part);
            }

            // Update product in inventory
            Inventory.updateProduct(id, product);

            // Close form and refresh DataGridView
            Close();
            MainForm.productsDataGrid.Update();
            MainForm.productsDataGrid.Refresh();
        }
        //cancel
        private void btnCancelModify_Click(object sender, EventArgs e)
        {
            Close();
            MainForm.productsDataGrid.ClearSelection();
        }

        private void thisBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            candidateModifyGridView.ClearSelection();
            associatedModifyGridView.ClearSelection();
        }

    }
}
