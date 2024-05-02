﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C968_Kondrla
{
    public class OutsourcedPart : Part
    {
        public string CompanyName { get; set; }

        public OutsourcedPart() { }

        public OutsourcedPart(string name, int inStock, decimal price, int max, int min, string companyName)
        {
            PartID = (Inventory.AllParts.Count);
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
            CompanyName = companyName;
        }

        public OutsourcedPart(int partID, string name, int inStock, decimal price, int max, int min, string companyName)
        {
            PartID = partID;
            Name = name;
            Price = price;
            InStock = inStock;
            Max = max;
            Min = min;  
            CompanyName = companyName;
        }
     }
}
