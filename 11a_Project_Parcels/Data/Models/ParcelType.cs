using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11a_Project_Parcels.Data.Models
{
    public class ParcelType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Parcel> Parcels { get; set; }
    }
}
