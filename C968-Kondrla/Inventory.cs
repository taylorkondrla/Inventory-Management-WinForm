using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968_Kondrla
{
    class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();


        //Add Product to Binding List
        public static void AddProduct(Product prod)
        {
            Products.Add(prod);
        }

        //Remove Product fron Binding List
        public static bool RemoveProduct(int prodID)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].ProductID == prodID)
                {
                    Products.Remove(Products[i]);
                    MessageBox.Show("Product sucessfully removed.");
                    return true; // product's deletion from the list

                }
            }
            MessageBox.Show("Product not sucessfully removed.");
            return false; //e removal process was unsuccessful

        }
        //Look up a product
        public static Product lookupProduct(int prodID)
        {
            foreach (Product prod in Products)
            {
                if (prod.ProductID == prodID)
                {
                    return prod;
                }
            }
            Product noMatch = new Product();
            return noMatch;
        }
        //Update a product
        public static void updateProduct(int prodID, Product prod)
        {
            foreach (Product currentProduct in Products)
            {
                if (currentProduct.ProductID == prodID)
                {
                    currentProduct.Name = prod.Name;
                    currentProduct.InStock = prod.InStock;
                    currentProduct.Price = prod.Price;
                    currentProduct.Max = prod.Max;
                    currentProduct.Min = prod.Min;
                    currentProduct.AssociatedParts = prod.AssociatedParts;
                    return;
                }

            }
        }
        //Add parts
        public static void addPart(Part part)
        {
            AllParts.Add(part);
        }

        //Remove parts from list
        public static bool DeletePart(Part part)
        {
            int partID = part.PartID;
            Part deletedPart = LookupPart(partID);
            if (deletedPart == null)
            {
                return false;
            }
            else
            {
                AllParts.Remove(deletedPart);
                return true;
            }
        }
        //Look up part by id
        public static Part LookupPart(int partID)
        {
            foreach (Part part in AllParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            Part noMatch = null;
            return noMatch;
        }

        // Look up part by name

        public static Part LookupPart(string partName)
        {
            // Case-insensitive search by part name
            return AllParts.FirstOrDefault(part => part.Name.Equals(partName, StringComparison.OrdinalIgnoreCase));
        }

        //Update part in list
        public static void updatePart(int partID, Part part)
        {
            foreach (Part currentPart in AllParts)
            {
                if (currentPart.PartID == partID)
                {
                    DeletePart(currentPart);
                    addPart(part);
                    return;
                }
            }
            
        }
        //Populate lists with the example data
        public static void PopulateLists()
        {
            Product exampleProduct = new Product("Bicycle", 4, 2.00m, 8, 6);
            Products.Add(exampleProduct);

            Part exampleInHousePart = new InHousePart(1, "Wheel", 8, 4.00m, 22, 8, 1024);
            AllParts.Add(exampleInHousePart);

            Part exampleInHousePart1 = new InHousePart(2, "Seat", 6, 3.50m, 15, 5, 1025);
            AllParts.Add(exampleInHousePart1);

            Part exampleInHousePart2 = new InHousePart(3, "Handlebar", 10, 5.00m, 20, 8, 1026);
            AllParts.Add(exampleInHousePart2);

            Part exampleOutsourcedPart = new OutsourcedPart(4, "Pedal", 12, 1.00m, 40, 10, "Pedal Company");
            AllParts.Add(exampleOutsourcedPart);
        }
    }
}
