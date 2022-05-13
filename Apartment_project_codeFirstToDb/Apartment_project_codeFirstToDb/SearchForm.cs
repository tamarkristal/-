using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using CheckBox = System.Windows.Forms.CheckBox;
using GroupBox = System.Windows.Forms.GroupBox;

namespace Apartment_project_codeFirstToDb
{
    public partial class SearchForm : Form
    {
        RealEstateAgency Apartment = new RealEstateAgency();
        public SearchForm()
        {
            InitializeComponent();
            Apartment.RentApartments.Include("Furnitures").ToList();
            Apartment.RentApartments.Include("Owners").ToList();
            Apartment.SoldApartments.Include("Owners").ToList();
            
        }
    // כפתור חיפוש
        private void btn_search_Click(object sender, EventArgs e)
        {
            var t = Apartment.SoldApartments.ToList<BaseApartment>().
                    Union(Apartment.RentApartments.ToList<BaseApartment>());
            string nameChoise = cm_search.Text;
            if (nameChoise == "דירות להשכרה")
                dg_show_search.DataSource = Apartment.RentApartments.ToList();
            
            if (nameChoise == "דירות למכירה")
                dg_show_search.DataSource = Apartment.SoldApartments.ToList();
            
            if (nameChoise == "דירות שמחירן נמוך מהממוצע")
            {
                double sumAvg = Apartment.SoldApartments.Sum(c => c.Price) / Apartment.SoldApartments.Count();
                sumAvg += Apartment.RentApartments.Sum(c => c.Price) / Apartment.RentApartments.Count();
                dg_show_search.DataSource = t.ToList()
                    .Where(c => c.Price < sumAvg).ToList();
            }
            
            if (nameChoise == "דירות שיש להן ריהוט")
            {

                var q1 = Apartment.RentApartments.Where(c => c.Furnitures.Count() > 0).ToList();
                dg_show_search.DataSource = (q1);
            }
            
            if (nameChoise == "סווג הדירות בחלוקה עפי מחיר מקסימאלי ומחיר מינמאלי לפי ערים")
            {
                dg_show_search.DataSource = t.ToList().GroupBy(c => c.Address.City ).
                    Select(c => new
                    {
                        city = c.Key,
                        countAprtments = c.Count(),
                        maxPrice = c.Max(m=>m.Price),
                        minPrice = c.Min(min=>min.Price),
                    }).ToList();
            }
            //חיפוש לפי id
                if (!string.IsNullOrEmpty(tx_id_owner.Text) )
                {

                    int num_id = int.Parse(tx_id_owner.Text);

                    var blogs1 = Apartment.Owners.Include("Apartments").ToList();

                    var q = Apartment.Owners.Single(c => c.Id == num_id);
                    var q1 = q.Apartments.ToList();

                    dg_show_search.DataSource = q1;
                }
            else
            if (!string.IsNullOrEmpty(tx_street.Text)&&!string.IsNullOrEmpty(tx_city.Text))

            {
                dg_show_search.DataSource = t.
                    Where(c => c.Address.City == tx_city.Text && c.Address.Street == tx_street.Text).ToList();
            }
        }// כפתור הצגת הכל
        private void btn_showAll_Click(object sender, EventArgs e)
        {
            dg_show_search.DataSource = Apartment.SoldApartments.ToList<BaseApartment>().
                     Union(Apartment.RentApartments.ToList<BaseApartment>()).ToList();
        }
        // כפתור דירה להשכרה חדשה
        private void btn_mew_Click(object sender, EventArgs e)
        {
            RentApartment rent = new RentApartment();
            rent.Owners = new List<PropertyOwner> { new PropertyOwner { FirstName="",LastName="" } };
            rent.Address = new Address();
            rent.Furnitures = new List<Furniture> { new Furniture() };
            Form2 showDatails = new Form2(rent);
            showDatails.Show();
        }
        //בחירת דירה להצגת פרטים
        private void dg_show_search_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {    
            var item = dg_show_search.SelectedRows[0];
            BaseApartment ba = item.DataBoundItem as BaseApartment;
            Form2 showDatails = new Form2(ba,Apartment);
            showDatails.Show();
        }
        // כפתור מחיקה
        private void btn_delete_Click(object sender, EventArgs e)
        {
            
            var deleteItem = dg_show_search.SelectedRows[0].DataBoundItem;
            if (deleteItem is SoldApartment)
            {
                Apartment.SoldApartments.Remove(deleteItem as SoldApartment);
            }
            else
            {
                Apartment.RentApartments.Include("Furnitures").ToList();
                Apartment.RentApartments.Remove(deleteItem as RentApartment);
            }
            Apartment.SaveChanges();
        }

        // כפתור דירה למכירה חדשה
        private void btn_newSold_Click(object sender, EventArgs e)
        {
            SoldApartment sold = new SoldApartment();
            sold.Owners = new List<PropertyOwner> { new PropertyOwner { FirstName="",LastName="" } };
            sold.Address = new Address();
            Form2 showDatails = new Form2( sold);
            showDatails.Show();
        }
    }
}