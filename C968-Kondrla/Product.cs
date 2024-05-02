using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Kondrla
{
    public class Product
    {
        public BindingList<Part> AssociatedParts = new BindingList<Part>();

        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public Product() { }

        public Product(string name, int inventory, decimal price, int max, int min)
        {
            ProductID = Inventory.Products.Count + 1;
            Name = name;
            Price = price;
            InStock = inventory;
            Max = max;
            Min = min;
        }

        //Add associated parts
        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }
        //Remove associated parts
        public bool RemoveAssociatedPart(int partID) 
        {
            bool wasRemoved = false;
            foreach (Part part in AssociatedParts) 
            {
                if (part.PartID == partID)
                {
                    AssociatedParts.Remove(part);
                    return wasRemoved = true;
                }
                else
                {
                    wasRemoved = false;
                }
            }
            return wasRemoved;
        }
        //Look up part in associated part
        public Part LookupAssociatedPart(int partnumber) //pass an int PartID to return an object
        {
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partnumber)
                {
                    return part;
                }
            }
            return null; // Return null if the part is not found
        }
    }
}
