using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Kondrla
{
    public class InHousePart : Part
    {
        public int MachineID { get; set; }
        public InHousePart() { }
        public InHousePart(string name, decimal price, int inStock, int min, int max, int machineID)
        {
            Name = name;
            InStock = inStock;
            Price = price;
            Max = max;
            Min = min;
            MachineID = machineID;
        }

        public InHousePart(int partID, string name, int inStock, decimal price, int max, int min, int machineID)
        {
            PartID = partID;
            Name = name;
            InStock = inStock;
            Price = price;
            Max = max;
            Min = min;
            MachineID = machineID;
        }

    }
}
