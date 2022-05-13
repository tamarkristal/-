using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment_project_codeFirstToDb
{
    [ComplexType]
        public class Address
    { 
        public int AddressId { get; set; }
      [Required]
        public string City { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public int NumHouse { get; set; }
        
        public int Floor { get; set; }

        public override string ToString()
        {
            return City + " " + Street + " " + NumHouse + " קומה: " + Floor;
        }
    }
}
