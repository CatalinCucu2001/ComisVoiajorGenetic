using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComisVoiajorGenetic.Utils;

namespace ComisVoiajorGenetic.Entity
{
    internal class City
    {
        public int Id { get; set; }

        public Point Location { get; set; }

        public string Name { get; set; }

        public City() { }
        public City(Point location, string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Id = int.Parse(name.Substring(GlobalSettings.CityPrefixName.Length));
            Location = location;
        }

        public City(int id, Point location, string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Id = id;
            Location = location;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as City);
        }

        public override int GetHashCode()
        {
            return Id;
        }

        public bool Equals(City city)
        {
            return Id == city.Id;
        }
    }
}
