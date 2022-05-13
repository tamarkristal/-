using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment_project_codeFirstToDb
{
    class MediateInitializer : DropCreateDatabaseIfModelChanges<RealEstateAgency>
    {
        protected override void Seed(RealEstateAgency context)
        {
            var flatToRent = new RentApartment
            {
                ApartmentId = 4,
                Address = new Address { City = "בני ברק", Street = "צייטלין", Floor = 1, NumHouse = 4 },
                AirConditioning = true,
                AirSides = AirSides.דרום,
                Contractperiod = 5,
                Price = 100,
                Elevators = true,
                ApartmentType = "Rent",
                DateOfEvacuation= new DateTime(2020,7,1),
                CountOfRooms=5,
                Furnitures = new List<Furniture> { new Furniture { FurnitureId = 3, NameFurniture = "ארון ספרים", TypeOfFurniture = Type.חדש, Weight = 1500 } },
                Owners = new List<PropertyOwner> { new PropertyOwner { FirstName = "אברהם", LastName = "אהרוני", Id = 32503888, MobilePhone = "052761866", PhoneNumber = "0772186440", } }

            };
            var flatToRent2 = new RentApartment
            {
                ApartmentId = 5,
                Address = new Address { City = "ירושלים", Street = "דקר", Floor = 3, NumHouse = 17 },
                AirConditioning = false,
                AirSides = AirSides.מזרח,
                Contractperiod = 6,
                Price = 4500000,
                ApartmentType = "Rent",
                Elevators = true,
                DateOfEvacuation = new DateTime(2020,1,1),
                CountOfRooms = 5,
                Furnitures = new List<Furniture> { new Furniture { FurnitureId = 4, NameFurniture = "שולחן פינתי", TypeOfFurniture = Type.במצב_טוב, Weight = 1300 } },
                Owners = new List<PropertyOwner> { new PropertyOwner { FirstName = "יונתן", LastName = "שלומי", Id = 32503888, MobilePhone = "053333333", PhoneNumber = "0772186440" } }

            };
            var flatToRent3 = new RentApartment
            {
                ApartmentId = 6,
                Address = new Address { City = "אלעד", Street = "חיים משה", Floor = 3, NumHouse = 18 },
                AirConditioning = true,
                AirSides = AirSides.מערב,
                Contractperiod = 7,
                ApartmentType = "Rent",
                Price = 450000000,
                Elevators = true,
                DateOfEvacuation = new DateTime(2020, 12, 1),
                CountOfRooms = 5,
                Furnitures = new List<Furniture> { new Furniture { FurnitureId = 4, NameFurniture = "מקרר", TypeOfFurniture = Type.חדש, Weight = 1300 } },
                Owners = new List<PropertyOwner> { new PropertyOwner { FirstName = "יהושע", LastName = "שוייגר", Id = 32503888, MobilePhone = "053333333", PhoneNumber = "055555555" } }

            };
            var flatToSale = new SoldApartment
            {
                ApartmentId = 1,
                AcommonTaboo = true,
                AirConditioning = true,
                Address = new Address { City = "ירושלים", Street = "דקר", Floor = 4, NumHouse = 5 },
                Elevators = false,
                ApartmentType = "Sold",
                AirSides =AirSides.דרום
               ,CountOfRooms=8,
              
                Price=100000,
                Owners= new List<PropertyOwner> { new PropertyOwner { FirstName="chani",LastName="gani",Id=32503888,MobilePhone="0548477287",PhoneNumber="0772186440" } }
            };
            var flatToSale2 = new SoldApartment
            {
                ApartmentId = 2,
                AcommonTaboo = false,
                AirConditioning = false,
                ApartmentType = "Sold",
                Address = new Address { City = "פתח תקוה", Street = "טרומפלדור", Floor = 1, NumHouse = 9 },
                Elevators = true,
                AirSides = AirSides.צפון
               ,
                CountOfRooms = 2,
               
                NeighbersInBuilding = 22,
                Price = 500000,
                Owners = new List<PropertyOwner> { new PropertyOwner { FirstName = "יעל", LastName = "נחמיאס", Id = 325039675, MobilePhone = "054444444", PhoneNumber = "036164444" } }
            };
            var flatToSale3 = new SoldApartment
            {
                ApartmentId = 3,
                AcommonTaboo = true,
                AirConditioning = false,
                ApartmentType = "Sold",
                Address = new Address { City = "גבעתיים", Street = "טרומפלדור", Floor =5, NumHouse = 12 },
                Elevators = false,
                AirSides = AirSides.מזרח
   ,
                CountOfRooms = 7,
                NeighbersInBuilding = 14,
                Price = 8000000,
                Owners = new List<PropertyOwner> { new PropertyOwner { FirstName = "מיכל", LastName = "ביטון", Id = 325039675, MobilePhone = "0556770576", PhoneNumber = "036164444" } }
            };
            context.SoldApartments.Add(flatToSale);
          context.SoldApartments.Add(flatToSale2);
            context.SoldApartments.Add(flatToSale3);
            context.RentApartments.Add(flatToRent);
           context.RentApartments.Add(flatToRent2);
            context.RentApartments.Add(flatToRent3);
            context.SaveChanges();
        }
    }
}
