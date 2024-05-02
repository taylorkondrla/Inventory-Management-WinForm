using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace C968_Kondrla
{
    public partial class AddPart : Form
    {
        public AddPart()
        {
            InitializeComponent();
            // Determine the next available part ID
            int nextPartID = Inventory.AllParts.Count + 1;

            // Set the part ID textbox with the next available ID
            textIDAddPart.Text = nextPartID.ToString();
        }

        private void rdbtnPartInHouse_CheckedChanged(object sender, EventArgs e)
        {
            AddPartMachineIDLabel.Text = "Machine ID";
        }

        private void rdbtnPartOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            AddPartMachineIDLabel.Text = "Company Name";
        }
        //save
        private void btnAddPartSave_Click(object sender, EventArgs e)
        {
            int partID;
            int inventory;
            decimal price;
            int min;
            int max;
            int machineID;

            // Try parsing the inventory field
            try
            {
                inventory = int.Parse(textInventoryAddPart.Text);
                if (inventory < 0)
                {
                    MessageBox.Show("Error! Inventory cannot be negative.");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Error! Inventory must be numeric.");
                return;
            }

            // Try parsing the price field
            try
            {
                price = decimal.Parse(textPriceAddPart.Text);
                if (price < 0)
                {
                    MessageBox.Show("Error! Price cannot be negative.");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Error! Price must be numeric.");
                return;
            }

            // Try parsing the min field
            try
            {
                min = int.Parse(textMinAddPart.Text);
                if (min < 0)
                {
                    MessageBox.Show("Error! Min cannot be negative.");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Error! Min must be numeric.");
                return;
            }

            // Try parsing the max field
            try
            {
                max = int.Parse(textMaxAddPart.Text);
                if (max < 0)
                {
                    MessageBox.Show("Error! Max cannot be negative.");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Error! Max must be numeric.");
                return;
            }

            // Validate the "Company Name" field if Outsourced part is selected
            if (rdbtnPartOutsourced.Checked)
            {
                // Check if the input is numeric
                if (int.TryParse(textMachineIDAddPart.Text, out _))
                {
                    MessageBox.Show("Error! Company Name cannot be a number. Please enter a valid name.");
                    return;
                }
            }

            // Try parsing the machineID field if In-House part is selected
            if (rdbtnPartInHouse.Checked)
            {
                try
                {
                    machineID = int.Parse(textMachineIDAddPart.Text);
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
            }
            partID = int.Parse(textIDAddPart.Text);
            string name = textNameAddPart.Text;
            inventory = int.Parse(textInventoryAddPart.Text);
            price = decimal.Parse(textPriceAddPart.Text);
            min = int.Parse(textMinAddPart.Text);
            max = int.Parse(textMaxAddPart.Text);

            if (inventory > max || inventory < min)
            {
                MessageBox.Show("Error! Inventory amount must be inbetween max and min.");
                return;
            }

            if (min > max)
            {
                MessageBox.Show("Error! Max must be greater than min.");
                return;
            }

            if (rdbtnPartInHouse.Checked)
            {
                try
                {
                    machineID = int.Parse(textMachineIDAddPart.Text);
                }
                catch
                {
                    MessageBox.Show("Error! Machine ID must be numeric.");
                    return;
                }
                machineID = int.Parse(textMachineIDAddPart.Text);
                InHousePart InPart = new InHousePart(partID, name, inventory, price, max, min, machineID);
                Inventory.addPart(InPart);
            }
            if (rdbtnPartOutsourced.Checked)
            {
                OutsourcedPart OutPart = new OutsourcedPart(partID, name, inventory, price, max, min, textMachineIDAddPart.Text);
                Inventory.addPart(OutPart);
            }
            Close();


        }



        //cancel
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        

    }
}
