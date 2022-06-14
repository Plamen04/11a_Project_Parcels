using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _11a_Project_Parcels.Data.Models;
using System.Data.Entity;

namespace _11a_Project_Parcels.Data
{
    public class ParcelContext:DbContext
    {
        public ParcelContext():base("name=ParcelContext")
        {

        }
        public DbSet<Parcel> Parcels { get; set; }
        public DbSet<ParcelType> ParcelTypes { get; set; }
    }
}
