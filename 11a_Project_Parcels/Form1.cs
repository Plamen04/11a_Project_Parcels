using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _11a_Project_Parcels.Data.Models;
using _11a_Project_Parcels.Data;
using _11a_Project_Parcels.Controller;

namespace _11a_Project_Parcels
{
    public partial class FormParcel : Form
    {
        ParcelBusiness parcelController = new ParcelBusiness();
        public FormParcel()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Parcel parcel = new Parcel();
            parcel.Name = txt_PackageName.Text;
            parcel.Description = txt_Description.Text;
            parcel.Price = decimal.Parse(txt_Price.Text);
            parcel.Weight = double.Parse(txt_Weight.Text);
            parcel.parcelType = cb_Type.Text;
            if (parcel != null)
            {
                parcelController.Add(parcel);
            }
            else MessageBox.Show("Values cannot be null!");
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_ID.Text);
            Parcel parcel = parcelController.Get(id);
            if (parcel != null)
            {
                parcel.Name = txt_PackageName.Text;
                parcel.Description = txt_Description.Text;
                parcel.Price = decimal.Parse(txt_Price.Text);
                parcel.Weight = double.Parse(txt_Weight.Text);
                parcel.parcelType = cb_Type.Text;
                parcelController.Update(parcel);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_ID.Text);
            parcelController.Delete(id);
        }

        private void FormParcel_Load(object sender, EventArgs e)
        {
            var products = parcelController.GetAll();
            dataGridView1.DataSource = products;
        }
    }
}
