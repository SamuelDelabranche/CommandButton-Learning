using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandButton.Model
{
    public class Item
    {
        public Item(string name, int serialNumber, int quantiry)
        {
            Name = name;
            SerialNumber = serialNumber;
            Quantiry = quantiry;
        }

        public string Name { get; set; }
        public int SerialNumber { get; set; }
        public int Quantiry { get; set; }

    }
}
