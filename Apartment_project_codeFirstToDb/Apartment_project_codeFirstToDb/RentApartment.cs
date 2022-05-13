using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Apartment_project_codeFirstToDb
{
   public class RentApartment:BaseApartment
    {
       

        public int Contractperiod { get; set; }
        [Required]
        public DateTime DateOfEvacuation { get; set; }
        public virtual List<Furniture> Furnitures { get; set; }

    }
}
