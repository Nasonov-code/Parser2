using System;

namespace Parser2
{
    public class CargoInvite
    {
        public String Id { get; set; }

        public DateTime DateOfShipment { get; set; }
        public int NumberT { get; set; }
        public string NumberInvoice { get; set; }
        public string Cargo { get; set; }
        public string Stamp { get; set; }
        public string Station { get; set; }
        public double NetWeight { get; set; }
        public double GrossWeight { get; set; }
        public string NumberDT { get; set; }
        public string Recipient { get; set; }
        public DateTime LoadingDateFrom { get; set; }
        public DateTime DateOfLoadingBy { get; set; }
    }
}
