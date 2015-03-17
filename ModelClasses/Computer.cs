using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory;

namespace ModelClasses
{
    class Computer : IHardware
    {
        public string HardwareName { get; set; }
        public string Model { get; set; }
        public string Location { get; set; }
        public DateTime DateOfChange { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public long SerieNUmmer { get; set; }
        public string Operativsystem { get; set; }
    }
}
