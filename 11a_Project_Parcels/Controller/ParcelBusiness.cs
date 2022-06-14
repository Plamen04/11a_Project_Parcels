using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _11a_Project_Parcels.Data.Models;
using _11a_Project_Parcels.Data;

namespace _11a_Project_Parcels.Controller
{
    class ParcelBusiness
    {
        private ParcelContext parcelContext = new ParcelContext();
        public List<Parcel> GetAll()
        {
            using (parcelContext = new ParcelContext())
            {
                return parcelContext.Parcels.ToList();
            }
        }
        public void Add(Parcel parcel)
        {
            using (parcelContext = new ParcelContext())
            {
                parcelContext.Parcels.Add(parcel);
                parcelContext.SaveChanges();
            }
        }
        public Parcel Get(int id)
        {
            using (parcelContext = new ParcelContext())
            {
                return parcelContext.Parcels.Find(id);
            }
        }
        public void Update(Parcel parcel)
        {
            using (parcelContext = new ParcelContext())
            {
                var items1 = parcelContext.Parcels.Find(parcel.Id);
                if (items1 != null)
                {
                    parcelContext.Entry(items1).CurrentValues.SetValues(parcel);
                    parcelContext.SaveChanges();
                }
            }
        }
        public void Delete(int id)
        {
            Parcel parcel = parcelContext.Parcels.Find(id);
            if (parcel != null)
            {
                parcelContext.Parcels.Remove(parcel);
                parcelContext.SaveChanges();
            }
        }
    }
}
