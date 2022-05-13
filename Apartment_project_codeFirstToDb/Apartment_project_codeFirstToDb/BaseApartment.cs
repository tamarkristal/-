using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment_project_codeFirstToDb
{
    [Flags]
 public   enum AirSides{דרום,צפון,מערב,מזרח}
    
  public abstract class BaseApartment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int ApartmentId { get; set; }
        public Address Address { get; set; }
        public AirSides AirSides  { get; set; }
        public double Price { get; set; }
        public int CountOfRooms { get; set; }
        public bool Elevators { get; set; }
        public bool AirConditioning { get; set; }
        public string ApartmentType { get; set; }

        public virtual List<PropertyOwner> Owners { get; set; }

    }
}
