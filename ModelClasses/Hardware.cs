using System;

namespace ModelClasses
{
    public interface IHardware
    {


        string HardwareName { get; set; }
        string Model { get; set; }
        string Location { get; set; }
        DateTime DateOfChange { get; set; }
        DateTime DateOfPurchase { get; set; }
        long SerieNUmmer { get; set; }
        string Operativsystem { get; set; }




    }
}