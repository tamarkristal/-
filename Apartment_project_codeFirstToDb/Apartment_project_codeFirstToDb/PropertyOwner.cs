using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment_project_codeFirstToDb
{
public    class PropertyOwner
    {
     [Key]
        public int  Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
       
        public string MobilePhone { get; set; }
        public virtual List<BaseApartment> Apartments { get; set; }
        public override string ToString()
        {
            return Id+ " " +LastName+ " "+PhoneNumber+" "+MobilePhone;
        }
    }
}
