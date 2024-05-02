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
    public partial class ModifyPart : Form
    {
        MainForm MainForm = (MainForm)Application.OpenForms["MainForm"];
        public ModifyPart(InHousePart inPart)
        {
            InitializeComponent();

            ModPartIDText.ReadOnly = true;

            rdbtnModifyPartInHouse.Checked = true;
            ModPartIDText.Text = inPart.PartID.ToString();
            ModPartNameText.Text = inPart.Name;
            ModPartInventoryText.Text = inPart.InStock.ToString();
            ModPartPriceText.Text = inPart.Price.ToString();
            ModPartMaxText.Text = inPart.Max.ToString();
            ModPartMinText.Text = inPart.Min.ToString();
            ModPartMachineIDText.Text = inPart.MachineID.ToString();

        }

        public ModifyPart(OutsourcedPart outsourcedPart)
        {
            InitializeComponent();
            ModPartIDText.ReadOnly = true;
            rdbtnModifyPartOutsourced.Checked = true; // Set the correct radio button
            ModPartIDText.Text = outsourcedPart.PartID.ToString();
            ModPartNameText.Text = outsourcedPart.Name;
            ModPartInventoryText.Text = outsourcedPart.InStock.ToString();
            ModPartPriceText.Text = outsourcedPart.Price.ToString();
            ModPartMaxText.Text = outsourcedPart.Max.ToString();
            ModPartMinText.Text = outsourcedPart.Min.ToString();
            ModPartMachineIDText.Text = outsourcedPart.CompanyName; // Update the text to company name
        }

        //save
        private void btnModPartSave_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(ModPartMinText.Text, out int min) ||
                !int.TryParse(ModPartMaxText.Text, out int max) ||
                !int.TryParse(ModPartInventoryText.Text, out int inStock) ||
                !decimal.TryParse(ModPartPriceText.Text, out decimal price))
            {
                MessageBox.Show("ERROR! Enter numeric values.");
                return;
            }

            if (min < 0 || max < 0 || inStock < 0 || price < 0)
            {
                MessageBox.Show("ERROR! Values cannot be negative.");
                return;
            }

            if (min > max)
            {
                MessageBox.Show("ERROR! Max must be greater than Min.");
                return;
            }

            if (inStock > max || inStock < min)
            {
                MessageBox.Show("ERROR! Inventory must be between Max and Min.");
                return;
            }

            int id = int.Parse(ModPartIDText.Text);
            string name = ModPartNameText.Text;

            // Check if In-House part is selected
            if (rdbtnModifyPartInHouse.Checked)
            {
                try
                {
                    int machineID = int.Parse(ModPartMachineIDText.Text);
                    if (machineID < 0)
                    {
                        MessageBox.Show("Error! Machine ID cannot be negative.");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Error! Machine ID must be numeric.");
                    return;
                }

                // Create In-House part object
                Part part = new InHousePart(id, name, inStock, price, max, min, int.Parse(ModPartMachineIDText.Text));
                Inventory.updatePart(id, part);
            }
            else // Outsourced part is selected
            {
                // Check if company name is empty or numeric
                string companyName = ModPartMachineIDText.Text;
                if (string.IsNullOrWhiteSpace(companyName) || companyName.Any(char.IsDigit))
                {
                    MessageBox.Show("Error! Company Name cannot be a number.");
                    return;
                }

                // Create Outsourced part object
                Part part = new OutsourcedPart(id, name, inStock, price, max, min, companyName);
                Inventory.updatePart(id, part);
            }


            // Close form and update DataGridView
            Close();
            MainForm.partsDataGrid.Update();
            MainForm.partsDataGrid.Refresh();
        }


        private void rdbtnModifyPartInHouse_CheckedChanged(object sender, EventArgs e)
        {
            ModPartMachineIDLabel.Text = "Machine ID";
        }

        private void rdbtnModifyPartOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            ModPartMachineIDLabel.Text = "Company Name";
        }

        private void btnModPartCancel_Click(object sender, EventArgs e)
        {
            Close();
            MainForm.partsDataGrid.ClearSelection();
        }
    }
}
