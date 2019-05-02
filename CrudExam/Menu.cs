using System;
using System.Collections.Generic;
using System.Linq;

namespace CrudExam
{
    public class Menu
    {
        public void Start()
        {
            Console.WriteLine("What do you want to do?\n" + "1) Add\n" + "2) Update\n" + "3) Delete\n" + "4) Exit");
            int menuChoice = int.Parse(Console.ReadLine());

            if(menuChoice == 1)
            {
                Console.WriteLine("1)Enter the country name: ");
                Country country = new Country()
                {
                    Name = Console.ReadLine()
                };
                Console.WriteLine("1)Enter the city name: ");
                City city = new City()
                {
                    Name = Console.ReadLine()
                };
                Console.WriteLine("1)Enter the street name: ");
                Street street = new Street()
                {
                    Name = Console.ReadLine()
                };

                using (var context = new CrudContext())
                {
                    context.Countries.Add(country);
                    context.Cities.Add(city);
                    context.Streets.Add(street);
                    context.SaveChanges();
                }
                Console.WriteLine("Sehr gut. Alles war hinzugefügt");
            }
            if (menuChoice == 2)
            {
                using (var context = new CrudContext())
               {
                    List<Country> countries = context.Countries.ToList<Country>();
                    Country country = countries[0];
                    Console.WriteLine("Enter your country changes: ");
                    country.Name = Console.ReadLine();
                    context.SaveChanges();
                    List<City> cities = context.Cities.ToList<City>();
                    City city = cities[0];
                    Console.WriteLine("Enter your city changes: ");
                    city.Name = Console.ReadLine();
                    context.SaveChanges();
                    List<Street> streets = context.Streets.ToList<Street>();
                    Street street = streets[0];
                    Console.WriteLine("Enter your street changes: ");
                    street.Name = Console.ReadLine();
                    context.SaveChanges();
                }
                Console.WriteLine("Sehr gut. Alles war aktualisiert");
            }
            if (menuChoice == 3)
            {
                Console.WriteLine("Are you sure?\n" + "1) Yes" + "2) No");
                int deleteChoice = int.Parse(Console.ReadLine());
                if (deleteChoice == 1)
                {
                    using (var context = new CrudContext())
                    {
                        List<Country> countries = context.Countries.ToList<Country>();
                        Country country = countries[0];
                        context.SaveChanges();
                        List<City> cities = context.Cities.ToList<City>();
                        City city = cities[0];
                        context.SaveChanges();
                        List<Street> streets = context.Streets.ToList<Street>();
                        Street street = streets[0];
                        context.SaveChanges();
                    }
                    Console.WriteLine("Sehr gut. Alles war gelöscht");
                }
                else
                {
                    Start();
                }
            }
            else
            {
                Console.WriteLine("Alles gutes!");
                Environment.Exit(0);
            }
        }
    }
}
