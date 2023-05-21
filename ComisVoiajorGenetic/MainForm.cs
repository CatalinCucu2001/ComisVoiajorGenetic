using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ComisVoiajorGenetic.Entity;
using ComisVoiajorGenetic.GeneticAlgorithm;
using ComisVoiajorGenetic.Utils;

namespace ComisVoiajorGenetic
{
    public partial class MainForm : Form
    {
        // Utils
        private int cityCounter;

        private CityGraph cities = new CityGraph();
        private Queue<City> cityQueue = new Queue<City>();

        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void CityMap_MouseDown(object sender, MouseEventArgs e)
        {
            // Insert new City Logic
            if ((e.Button & MouseButtons.Left) != 0)
            {
                // Check if a city is around
                var newCity = new City(cityCounter, e.Location, GlobalSettings.CityPrefixName + cityCounter);

                if (cities.TryAddCity(newCity))
                {
                    CityMap.DrawCity(newCity, GlobalSettings.DefaultCircleColor);
                    cityCounter++;
                }

            }

            // Create new Relation Logic
            if ((e.Button & MouseButtons.Right) != 0)
            {
                // Add city in Queue
                var city = cities.GetCityAroundLocation(e.Location);
                if (city != null)
                {
                    if (cityQueue.Count == 0)
                    {
                        CityMap.DrawCity(city, GlobalSettings.SelectedCircleColor);
                    }
                    cityQueue.Enqueue(city);
                }

                // Relation Logic
                if (cityQueue.Count == 2)
                {
                    var city1 = cityQueue.Dequeue();
                    var city2 = cityQueue.Dequeue();

                    // If the way will not intersect other cities
                    if (!cities.AreCitiesBetween(city1, city2))
                    {
                        cities.AddRelation(city1, city2);
                        CityMap.DrawRelation(city1, city2, GlobalSettings.DefaultRelationColor);
                    }
                    CityMap.DrawCity(city1, GlobalSettings.DefaultCircleColor);
                    CityMap.DrawCity(city2, GlobalSettings.DefaultCircleColor);
                }
            }
        }

        private void buttonClearMap_Click(object sender, EventArgs e)
        {
            CityMap.ClearMap();
            CityMap.Invalidate();
        }

        private void buttonDrawAllCities_Click(object sender, EventArgs e)
        {
            foreach (var city in cities.Cities.Values)
            {
                CityMap.DrawCity(city, GlobalSettings.DefaultCircleColor);
            }
            CityMap.Invalidate();
        }

        private void buttonDrawAllRelations_Click(object sender, EventArgs e)
        {
            var cities = this.cities.Cities;
            foreach (var citiesRelation in this.cities.Relations)
            {
                var currentCity = cities[citiesRelation.Key];
                foreach (var cityId in citiesRelation.Value.Where(cityId => cityId > currentCity.Id))
                {
                    CityMap.DrawRelation(currentCity, cities[cityId], GlobalSettings.DefaultRelationColor);
                }
            }
        }

        private void timerGeneration_Tick(object sender, EventArgs e)
        {

        }
    }
}
