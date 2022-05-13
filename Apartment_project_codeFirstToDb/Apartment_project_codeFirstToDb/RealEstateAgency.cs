using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;
using System.Data.Entity;

namespace Apartment_project_codeFirstToDb
{
  public  class RealEstateAgency : DbContext
    {
        public RealEstateAgency() : base("Data Source=SEMINAR-SQL;Initial Catalog=RealEstateAgencyTamar;Integrated Security=True")
        {
           
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RentApartment>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Rent");
            });

            modelBuilder.Entity<SoldApartment>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Sale");
            });
        }
        static RealEstateAgency()
        {
            Database.SetInitializer<RealEstateAgency>(new MediateInitializer());
        }
        public DbSet<SoldApartment> SoldApartments { get; set; }
        public DbSet<RentApartment> RentApartments { get; set; }
        public DbSet<PropertyOwner> Owners { get; set; }
    }
}
