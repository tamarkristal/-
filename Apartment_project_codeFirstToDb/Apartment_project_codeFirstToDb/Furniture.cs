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
  public  enum Type { ישן, חדש,יד_שניה,במצב_טוב }
   public class Furniture
    {
        [Key]
        public int FurnitureId { get; set; }
        [Required]
        public string NameFurniture { get; set; }
        public Type TypeOfFurniture { get; set; }
        public int Weight { get; set; }
        [Required]
        public int Price { get; set; }
        public override string ToString()
        {
            return  NameFurniture + " " + TypeOfFurniture + " משקל: " + Weight + " מחיר: " + Price;
        }
    }
}
