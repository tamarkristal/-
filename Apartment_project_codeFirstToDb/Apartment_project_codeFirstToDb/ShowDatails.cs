using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apartment_project_codeFirstToDb
{
   
    public partial class Form2 : Form
    {
      
        private BaseApartment ba;
        private BaseApartment apartment;
        RealEstateAgency Apartment=new RealEstateAgency();
        public Form2()
        {
            InitializeComponent();
            Apartment.RentApartments.Include("Furnitures").ToList();
            Apartment.RentApartments.Include("Owners").ToList();
            Apartment.SoldApartments.Include("Owners").ToList();

        }
        //חדש
        public Form2(BaseApartment apartment):this()
        {
            this.apartment = apartment;
            
            btnSave.Visible = false;

                dataGridOwners.DataSource=apartment.Owners.ToList();
            if (apartment is SoldApartment)
            {
                labelOwners.Visible = false;
                dataGridFurniturs.Visible = false;
                groupBoxApartmentRent.Visible = false;

            }
            else
            {
               
                dataGridFurniturs.DataSource = (apartment as RentApartment).Furnitures.ToList();
                groupBoxApartmentsSold.Visible = false;
                richTextBoxsoldApartment.Visible = false;
            }
        }
        // הצגת פרטים
        public Form2(BaseApartment ba, RealEstateAgency apartment) : this()
        {
            
            btnNewSave.Visible = false;
            Apartment = apartment;
            if (ba is SoldApartment)
            {
                groupBoxApartmentRent.Visible = false;
                dataGridFurniturs.Visible = false;
                labelOwners.Visible = false;
            }
            if (ba is RentApartment)
            {
                groupBoxApartmentsSold.Visible = false;
                richTextBoxsoldApartment.Visible = false;
            }
            this.ba = ba;
            if (ba is SoldApartment)
            {
                SoldApartment sold = ba as SoldApartment;
            
                textBoxNeighbers.Text = sold.NeighbersInBuilding.ToString();
                if (sold.AcommonTaboo)

                    checkBoxTaboo.Checked = true;
            }
            else
            {
                RentApartment rent = ba as RentApartment;
               
                dateTimePickerDateOfEvacuation.Value = rent.DateOfEvacuation;
                dataGridFurniturs.DataSource = rent.Furnitures.ToList();
                textBoxContractperiod.Text = rent.Contractperiod.ToString();
            }
            text_id.Text = ba.ApartmentId.ToString();
            textcity.Text = ba.Address.City;
            textstreet.Text = ba.Address.Street;
            textfloor.Text = ba.Address.Floor.ToString();
            textNumRooms.Text = ba.CountOfRooms.ToString();
            textPrice.Text = ba.Price.ToString();
            textNumHome.Text = ba.Address.NumHouse.ToString();
            checkBox_elevator.Checked = ba.Elevators;
            checkBox_airConditioner.Checked = ba.AirConditioning;
            switch (ba.AirSides)
            {
                case AirSides.דרום:
                    radioButton_D.Checked = true;
                    break;
                case AirSides.צפון:
                    radioButton_Z.Checked = true;
                    break;
                case AirSides.מערב:
                    radioButton_ME.Checked = true;
                    break;
                case AirSides.מזרח:
                    radioButton_MI.Checked = true;
                    break;
                default:
                    break;
            }

            dataGridOwners.DataSource = ba.Owners.ToList();

        }
        
        //שמירת עדכונים
        private void btnSave_Click(object sender, EventArgs e)
        {
            ba.Address.City = textcity.Text;

            ba.Address.Street = textstreet.Text;
            ba.Address.Floor = Convert.ToInt32(textfloor.Text);
            ba.Price = Convert.ToInt32(textPrice.Text);
            ba.Elevators = checkBox_elevator.Checked;

            ba.Address.NumHouse = Convert.ToInt32(textNumHome.Text);
            ba.CountOfRooms = Convert.ToInt32(textNumRooms.Text);
            ba.AirConditioning = checkBox_airConditioner.Checked;
            if (radioButton_ME.Checked)
                ba.AirSides = AirSides.מערב;
            else
            if (radioButton_Z.Checked)
                ba.AirSides = AirSides.צפון;
            else
            if (radioButton_D.Checked)
                ba.AirSides = AirSides.דרום;
            else
            if (radioButton_MI.Checked)
                ba.AirSides = AirSides.מזרח;


            if (ba is SoldApartment)
            {
                SoldApartment ApartmentSale = ba as SoldApartment;
                ApartmentSale.NeighbersInBuilding = Convert.ToInt32(textBoxNeighbers.Text);
                ApartmentSale.AcommonTaboo = checkBoxTaboo.Checked;
                ba.ApartmentType = "Sold";

            }
            else
            if (ba is RentApartment)
            {

                ba.ApartmentType = "Rent";
                RentApartment ApartmentRent = ba as RentApartment;
                ApartmentRent.DateOfEvacuation = dateTimePickerDateOfEvacuation.Value;
                ApartmentRent.Furnitures = (List<Furniture>)(dataGridFurniturs.DataSource);
                ApartmentRent.Contractperiod = Convert.ToInt32(textBoxContractperiod.Text);
            }
            Apartment.SaveChanges();
            this.Close();
        }
        //שמירת חדש

        private void btnNewSave_Click(object sender, EventArgs e)    
        {
            apartment.ApartmentId = Convert.ToInt32(text_id.Text);
            apartment.Address.City = textcity.Text;
            apartment.Address.Street = textstreet.Text;
            apartment.Address.Floor = Convert.ToInt32(textfloor.Text);
            apartment.Price = Convert.ToInt32(textPrice.Text);
            apartment.Elevators = checkBox_elevator.Checked;
            apartment.Address.NumHouse = Convert.ToInt32(textNumHome.Text);
            apartment.CountOfRooms = Convert.ToInt32(textNumRooms.Text);
            apartment.AirConditioning = checkBox_airConditioner.Checked;
            if (radioButton_ME.Checked)
                apartment.AirSides = AirSides.מערב;
            else
            if (radioButton_Z.Checked)
                apartment.AirSides = AirSides.צפון;
            else
            if (radioButton_D.Checked)
                apartment.AirSides = AirSides.דרום;
            else
            if (radioButton_MI.Checked)
                apartment.AirSides = AirSides.מזרח;
            if (apartment is SoldApartment)
            {
                SoldApartment ApartmentSale = apartment as SoldApartment;

                ApartmentSale.NeighbersInBuilding = Convert.ToInt32(textBoxNeighbers.Text);
                ApartmentSale.AcommonTaboo = checkBoxTaboo.Checked;
                apartment.ApartmentType = "Sold";
                Apartment.SoldApartments.Add(ApartmentSale);
            }
            else
            if (apartment is RentApartment)
            {
                apartment.ApartmentType = "Rent";
                RentApartment ApartmentRent = apartment as RentApartment;

                ApartmentRent.DateOfEvacuation = dateTimePickerDateOfEvacuation.Value;
                ApartmentRent.Furnitures = (List<Furniture>)(dataGridFurniturs.DataSource);
                ApartmentRent.Contractperiod = Convert.ToInt32(textBoxContractperiod.Text);
                Apartment.RentApartments.Add(ApartmentRent);
            }
            Apartment.SaveChanges();
            this.Close();
        }


    }
    }

