using ComisVoiajorGenetic.Entity;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComisVoiajorGenetic.GeneticAlgorithm;

namespace ComisVoiajorGenetic.Utils
{
    internal static class CityGraphExtension
    {
        public static float GetDistanceBetween(this City city1, City city2)
        {
            return city1.Location.GetDistanceTo(city2.Location);
        }

        public static float GetDistanceBetween(this CityGraph cities, int cityId1, int cityId2)
        {
            var city1 = cities.Cities[cityId1];
            var city2 = cities.Cities[cityId2];
            return city1.GetDistanceBetween(city2);
        }

        public static bool AreCitiesBetween(this CityGraph cities, City city1, City city2)
        {
            var increment = GlobalSettings.CircleRadius / (1.5f * city1.GetDistanceBetween(city2));
            var dX = city2.Location.X - city1.Location.X;
            var dY = city2.Location.Y - city1.Location.Y;
            for (var i = increment; i < 1; i += increment)
            {
                var intermediaryPoint = new Point(city1.Location.X + (int)(dX * i), city1.Location.Y + (int)(dY * i));
                var city = cities.GetCityAroundLocation(intermediaryPoint, 10);
                if (city == null || city.Equals(city1) || city.Equals(city2))
                {
                    continue;
                }
                return true;
            }
            return false;
        }

        public static float GetValueOfChromosome(this CityGraph cities, Chromosome chromosome)
        {
            // TODO - Optimize it
            var distance = 0f;
            for (int i = 0; i < chromosome.Genes.Length - 1; i++)
            {
                if (cities.CheckForRelation(chromosome.Genes[i], chromosome.Genes[i + 1]))
                {
                    distance += cities.GetDistanceBetween(chromosome.Genes[i], chromosome.Genes[i + 1]);
                }
                else
                {
                    distance += GlobalSettings.DistanceBetweenCitiesWithoutRelation;
                }
            }

            if (cities.CheckForRelation(chromosome.Genes[0], chromosome.Genes[cities.Cities.Count - 1]))
            {
                distance += cities.GetDistanceBetween(chromosome.Genes[0], chromosome.Genes[cities.Cities.Count - 1]);
            }
            else
            {
                distance += GlobalSettings.DistanceBetweenCitiesWithoutRelation;
            }

            if (distance < 0)
                throw new OverflowException("Distance is negative");

            return distance;
        }

        public static Chromosome GenerateValidChromosome(this CityGraph cities)
        {
            Chromosome chromosome = new Chromosome(cities.Cities.Count);
            chromosome.Shuffle();
            return chromosome;
        }
    }
}
