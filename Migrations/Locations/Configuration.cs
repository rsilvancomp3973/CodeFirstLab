namespace LabCodeFirst.Migrations.Locations
{
    using LabCodeFirst.Models.Locations;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LabCodeFirst.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"Migrations\Locations";
        }

        protected override void Seed(LabCodeFirst.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Provinces.AddOrUpdate(t => t.ProvinceName, getProvinces().ToArray());
            context.SaveChanges();

        }

        private List<Province> getProvinces()
        {
            List<Province> provinces = new List<Province>()
            {
                new Province() {ProvinceName = "BC",
                    Cities = new List<City>() {
                        new City(){ CityName = "Vancouver", Population = 2463231, },
                        new City(){ CityName = "Victoria", Population = 367770, },
                        new City(){ CityName = "Kelowna", Population = 192882, }
                    }
                },
               new Province() {ProvinceName = "Ontario",
                    Cities = new List<City>() {
                        new City(){ CityName = "Toronto", Population = 2615060, },
                        new City(){ CityName = "Ottawa", Population = 883391, },
                        new City(){ CityName = "Mississauga", Population = 713443, }
                    }
                },
               new Province() {ProvinceName = "Alberta",
                    Cities = new List<City>() {
                        new City(){ CityName = "Calgary", Population = 1235171, },
                        new City(){ CityName = "Edmonton", Population = 899447, },
                        new City(){ CityName = "Red Deer", Population = 99832, }
                    }
                },
            };
            return provinces;
        }


    }
}
