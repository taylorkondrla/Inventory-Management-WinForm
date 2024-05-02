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
    public partial class MainForm : Form
    {
       
        public MainForm()
        {
            InitializeComponent();

            //Load example parts and products
            Inventory.PopulateLists();

            //Load data grids
            partsDataGrid.DataSource = Inventory.AllParts;
            productsDataGrid.DataSource = Inventory.Products;

            partsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            partsDataGrid.ReadOnly = true;
            productsDataGrid.ReadOnly = true;

            partsDataGrid.AllowUserToAddRows = false;
            productsDataGrid.AllowUserToAddRows = false;

            partsDataGrid.MultiSelect = false;
            productsDataGrid.MultiSelect = false;
        }


        //Open Add Part Form
        private void addPartBtn_Click(object sender, EventArgs e)
        {
            AddPart addPart = new AddPart();
            addPart.Show();
        }

        //Open Modify Part Form
        private void modifyPartsBtn_Click(object sender, EventArgs e)
        {
            if (partsDataGrid.CurrentRow.DataBoundItem.GetType() == typeof(C968_Kondrla.InHousePart))
            {
                InHousePart inHousePart = (InHousePart)partsDataGrid.CurrentRow.DataBoundItem;
                new ModifyPart(inHousePart).ShowDialog();
            }
            else
            {
                OutsourcedPart outsourcedPart = (OutsourcedPart)partsDataGrid.CurrentRow.DataBoundItem;
                new ModifyPart(outsourcedPart).ShowDialog();
            }
            
        }
        //Search for part
        private void searchPartsBtn_Click(object sender, EventArgs e)
        {
            partsDataGrid.ClearSelection();

            if (!string.IsNullOrEmpty(searchParts.Text) && partsDataGrid.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in partsDataGrid.Rows)
                {
                    if (row.Cells[0].Value.ToString().Contains(searchParts.Text) || row.Cells[1].Value.ToString().Contains(searchParts.Text))
                    {
                        partsDataGrid.CurrentCell = row.Cells[0];
                        row.Selected = true;
                    }
                    if (row.Selected)
                    {
                        break;
                    }                    
                }
                if (partsDataGrid.SelectedRows.Count == 0)
                {
                    MessageBox.Show("No Match Found");
                }
            }
        }


        //Delete part
        private void DeletePartsBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this part?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) 
            {
                Part parttoDelete = (Part)partsDataGrid.CurrentRow.DataBoundItem;
                foreach (Product prod in Inventory.Products)
                {
                    foreach (Part parttryDelete in prod.AssociatedParts)
                    {
                        if (parttoDelete.PartID == parttryDelete.PartID)
                        {
                            MessageBox.Show("Cannot delete part. Part is associated with a product.");
                            return;
                        }
                    }
                }
                foreach (DataGridViewRow row in partsDataGrid.SelectedRows)
                {
                    partsDataGrid.Rows.RemoveAt(row.Index);
                    return;
                }
            }
        }

        //Open add product form
        private void addProductsBtn_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.Show();
        }
        //Modify product
        private void modifyProductsBtn_Click(object sender, EventArgs e)
        {
            Product selectedProd = (Product)productsDataGrid.CurrentRow.DataBoundItem;
            new ModifyProduct(selectedProd).Show();
        }

        //Delete Product
        private void deleteProductsBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Product productToDelete = (Product)productsDataGrid.CurrentRow.DataBoundItem;
                int productIdToDelete = productToDelete.ProductID;

                if (Inventory.RemoveProduct(productIdToDelete))
                {
                    MessageBox.Show("Product successfully removed.");
                    RefreshProductGrid(); // Update the product grid in the UI
                }
                else
                {
                    MessageBox.Show("Failed to remove product.");
                }
            }
            else
            {
                return;
            }
        }
        private void RefreshProductGrid()
        {
            productsDataGrid.DataSource = null; // Clear the current data source
            productsDataGrid.DataSource = Inventory.Products; // Reassign the data source to the updated list
        }

        //Search products
        private void searchProductsBtn_Click(object sender, EventArgs e)
        {
            productsDataGrid.ClearSelection();

            if (!string.IsNullOrEmpty(searchProducts.Text) && productsDataGrid.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in productsDataGrid.Rows)
                {
                    if (row.Cells[0].Value.ToString().Contains(searchProducts.Text) || row.Cells[1].Value.ToString().Contains(searchProducts.Text))
                    {
                        productsDataGrid.CurrentCell = row.Cells[0];
                        row.Selected = true;
                    }
                    if (row.Selected)
                    {
                        break;
                    }
                }
                if (productsDataGrid.SelectedRows.Count == 0)
                {
                    MessageBox.Show("No Match Found");
                }
            }
        }    


        //Exit
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
