using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11a_Project_Parcels.Data.Models
{
    public class Parcel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public double Weight { get; set; }
        public string parcelType { get; set; }
        public ParcelType ParcelType { get; set; }
    }
}
