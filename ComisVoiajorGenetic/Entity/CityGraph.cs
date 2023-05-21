using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using ComisVoiajorGenetic.Utils;

namespace ComisVoiajorGenetic.Entity
{
    internal class CityGraph
    {
        public Dictionary<int, City> Cities { get; set; }
        public Dictionary<int, HashSet<int>> Relations { get; set; }

        public CityGraph()
        {
            Cities = new Dictionary<int, City>();
            Relations = new Dictionary<int, HashSet<int>>();
        }

        public void AddCity(City city)
        {
            Cities.Add(city.Id, city);
            Relations.Add(city.Id, new HashSet<int>());
        }

        public void AddRelation(City city1, City city2)
        {
            if (!Cities.ContainsKey(city1.Id) || !Cities.ContainsKey(city2.Id))
                throw new InvalidOperationException("One of the cities are not in graph");
            if (city1.Equals(city2)) return;

            Relations[city1.Id].Add(city2.Id);
            Relations[city2.Id].Add(city1.Id);
        }

        public bool TryAddCity(City newCity)
        {
            if (Cities.ContainsKey(newCity.Id) 
                || Cities.Values.Any(city =>
                    newCity.Location.GetDistanceTo(city.Location) < GlobalSettings.MinimumDistanceBetweenCities))
            {
                return false;
            }
            Cities.Add(newCity.Id, newCity);
            Relations.Add(newCity.Id, new HashSet<int>());
            return true;
        }

        public City GetCityAroundLocation(Point point, int additionalDistance = 0)
        {
            var cities = Cities.Values.Where(city => city.Location.GetDistanceTo(point) < GlobalSettings.SelectCityRange + additionalDistance);
            using (var enumerator = cities.GetEnumerator())
            {
                enumerator.MoveNext();
                return enumerator.Current;
            }
        }

        public bool CheckForRelation(int cityId1, int cityId2)
        {
            return Relations[cityId1].Contains(cityId2);
        }
    }
}
