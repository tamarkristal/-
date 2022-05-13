using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment_project_codeFirstToDb
{
 public   class SoldApartment:BaseApartment
    {
       
        public bool AcommonTaboo { get; set; }
        public int NeighbersInBuilding { get; set; }
    }
}
