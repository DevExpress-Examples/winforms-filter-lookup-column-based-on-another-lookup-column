using DxSample.Models;
using System.Collections.Generic;
using System.Linq;

namespace DxSample {
    public static class DataContext {
        private static readonly IEnumerable<City> Cities;
        private static readonly IEnumerable<Country> Countries;
        private static readonly IEnumerable<Phone> Phones;

        static DataContext() {
            DataContext.Cities = new City[] {
                new City() { ID = 1, Name = "Washington", CityCode = "202", CountryCode = "1" },
                new City() { ID = 2, Name = "Los Angeles", CityCode = "213", CountryCode = "1" },
                new City() { ID = 3, Name = "San Francisco", CityCode = "415", CountryCode = "1" },
                new City() { ID = 4, Name = "New-York", CityCode = "718", CountryCode = "1" },
                new City() { ID = 5, Name = "Berlin", CityCode = "30", CountryCode = "49" },
                new City() { ID = 6, Name = "Bonn", CityCode = "228", CountryCode = "49" },
                new City() { ID = 7, Name = "Munhen", CityCode = "89", CountryCode = "49" },
                new City() { ID = 8, Name = "Paris", CityCode = "1", CountryCode = "33" },
                new City() { ID = 9, Name = "Lion", CityCode = "19", CountryCode = "33" },
                new City() { ID = 10, Name = "London", CityCode = "1274", CountryCode = "44" },
                new City() { ID = 11, Name = "Glasgo", CityCode = "141", CountryCode = "44" },
                new City() { ID = 12, Name = "Rome", CityCode = "6", CountryCode = "39" },
                new City() { ID = 13, Name = "Milan", CityCode = "2", CountryCode = "39" },
                new City() { ID = 14, Name = "Moscow", CityCode = "495", CountryCode = "7" }
            };
            DataContext.Countries = new Country[] {
                new Country() { ID = 1, Name = "USA", CountryCode = "1" },
                new Country() { ID = 2, Name = "Germany", CountryCode = "49" },
                new Country() { ID = 3, Name = "France", CountryCode = "33" },
                new Country() { ID = 4, Name = "Great Britain", CountryCode = "44" },
                new Country() { ID = 5, Name = "Italy", CountryCode = "39" },
                new Country() { ID = 6, Name = "Russia", CountryCode = "7" }
            };
            DataContext.Phones = new Phone[] {
                new Phone() { ID = 1, Name = "xxx", CountryCode = "39", CityCode = "6" },
                new Phone() { ID = 2, Name = "yyy", CountryCode = "33", CityCode = "19" },
                new Phone() { ID = 3, Name = "zzz", CountryCode = "1", CityCode = "202" }
            };
        }

        public static List<Phone> GetPhones() {
            return DataContext.Phones.ToList();
        }

        public static List<Country> GetCountries() {
            return DataContext.Countries.ToList();
        }

        public static List<City> GetAllCities() {
            return DataContext.Cities.ToList();
        }

        public static List<City> GetCitiesByCountryCode(string countryCode) {
            return DataContext.Cities.Where(c => c.CountryCode == countryCode).ToList();
        }
    }
}
