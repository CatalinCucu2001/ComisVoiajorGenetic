using ComisVoiajorGenetic.Entity;
using ComisVoiajorGenetic.GeneticAlgorithm;
using ComisVoiajorGenetic.Utils;

using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComisVoiajorGenetic
{
    public partial class MainForm : Form
    {
        // Utils
        private Random random = new Random();
        private int cityCounter;

        private CityGraph cities = new CityGraph();
        private Queue<City> cityQueue = new Queue<City>();
        private GeneticAlgorithmImpl genetic;

        private int chanceToAddRelation;
        public MainForm()
        {
            InitializeComponent();
            timerGeneration.Interval = trackBarTimer.Value;
        }

        private void CityMap_MouseDown(object sender, MouseEventArgs e)
        {
            if (!checkBoxEditMode.Checked)
            {
                return;
            }

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
                        CityMap.DrawRelation(city1, city2, GlobalSettings.DefaultRelationColor, GlobalSettings.RelationSize);
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
            CityMap.DrawAllCities(cities);
        }

        private void buttonDrawAllRelations_Click(object sender, EventArgs e)
        {
            CityMap.DrawAllRelations(cities);
        }

        private void checkBoxEditMode_CheckedChanged(object sender, EventArgs e)
        {
            buttonInitGenetic.Enabled = !checkBoxEditMode.Checked;
            buttonDrawAllChromosomes.Enabled = !checkBoxEditMode.Checked;
            buttonFilterChromosomes.Enabled = !checkBoxEditMode.Checked;
            buttonNextGeneration.Enabled = !checkBoxEditMode.Checked;

            buttonResetAll.Enabled = checkBoxEditMode.Checked;
            buttonResetRelations.Enabled = checkBoxEditMode.Checked;
            buttonRandomRelations.Enabled = checkBoxEditMode.Checked;
            trackBarChanceRelation.Enabled = checkBoxEditMode.Checked;

            if (checkBoxEditMode.Checked)
            {
                genetic = null;
            }
        }

        private void buttonInitGenetic_Click(object sender, EventArgs e)
        {
            var list = new List<Chromosome>();
            for (int i = 0; i < GlobalSettings.NumberOfParentChromosomes; i++)
            {
                list.Add(cities.GenerateValidChromosome());
            }
            genetic = new GeneticAlgorithmImpl(list);
            genetic.population.ForEach(chromosome => chromosome.Distance = cities.GetValueOfChromosome(chromosome));
            buttonDrawAllChromosomes.PerformClick();
        }

        private void timerGeneration_Tick(object sender, EventArgs e)
        {
            if (checkBoxEditMode.Checked || genetic == null)
                return;

            buttonNextGeneration.PerformClick();
            buttonFilterChromosomes.PerformClick();
            buttonDrawAllChromosomes.PerformClick();
        }

        private void buttonDrawAllChromosomes_Click(object sender, EventArgs e)
        {
            CityMap.ClearMap();
            CityMap.DrawAllCities(cities);
            CityMap.Invalidate();


            if (genetic.population.Count == 2)
            {
                CityMap.DrawChromosome(cities, genetic.population[0], (int)(GlobalSettings.RelationSize * 2.5));
                CityMap.DrawChromosome(cities, genetic.population[1], GlobalSettings.RelationSize);
            }
            else
            {
                foreach (var chromosome in genetic.population)
                {
                    CityMap.DrawChromosome(cities, chromosome, GlobalSettings.RelationSize);
                }
            }
            textBoxStatus.Log(genetic);
        }

        private void buttonNextGeneration_Click(object sender, EventArgs e)
        {
            if (genetic.population.Count != 2)
            {
                MessageBox.Show($@"Invalid number of Chromosomes - {genetic.population.Count}");
                return;
            }
            var ch1 = genetic.population[0];
            var ch2 = genetic.population[1];

            for (int r = 0; r < GlobalSettings.NumberOfRepeats; r++)
            {
                for (int i = 0; i < GlobalSettings.NumberOfCombination; i++)
                {
                    var result = ch1.CombineWith(ch2);
                    genetic.population.Add(result.Item1);
                    genetic.population.Add(result.Item2);
                }

                for (int i = 0; i < GlobalSettings.NumberOfMutations; i++)
                {
                    genetic.population.Add(ch1.Mutate());
                    genetic.population.Add(ch2.Mutate());
                }

                genetic.population = genetic.population
                    .Distinct(new ChromosomeEqualityComparer())
                    .ToList();
                ch1 = genetic.population[random.Next(genetic.population.Count)];
                ch2 = genetic.population[random.Next(genetic.population.Count)];
            }

            genetic.population.ForEach(chromosome => chromosome.Distance = cities.GetValueOfChromosome(chromosome));
            genetic.population = genetic.population.OrderBy(chromosome => chromosome.Distance).ToList();
        }

        private void buttonFilterChromosomes_Click(object sender, EventArgs e)
        {
            genetic.NaturalSelection();
        }

        private void checkBoxTimer_CheckedChanged(object sender, EventArgs e)
        {
            timerGeneration.Enabled = checkBoxTimer.Checked;
        }

        private void trackBarTimer_Scroll(object sender, EventArgs e)
        {
            timerGeneration.Interval = trackBarTimer.Value;
        }

        private void buttonRandomRelations_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < cities.Cities.Count - 1; i++)
            {
                for (int j = i + 1; j < cities.Cities.Count; j++)
                {
                    var city1 = cities.Cities[i]; 
                    var city2 = cities.Cities[j];
                    if (!cities.AreCitiesBetween(city1, city2) && random.Next(100) < chanceToAddRelation)
                    {
                        cities.AddRelation(city1, city2);
                        CityMap.DrawRelation(city1, city2, GlobalSettings.DefaultRelationColor, GlobalSettings.RelationSize);
                    }
                }
            }
        }

        private void trackBarChanceRelation_Scroll(object sender, EventArgs e)
        {
            chanceToAddRelation = trackBarChanceRelation.Value;
        }

        private void buttonDrawAll_Click(object sender, EventArgs e)
        {
            buttonClearMap.PerformClick();
            buttonDrawAllCities.PerformClick();
            buttonDrawAllRelations.PerformClick();
        }

        private void buttonResetRelations_Click(object sender, EventArgs e)
        {
            foreach (var keyValuePair in cities.Relations)
            {
                keyValuePair.Value.Clear();
            }
            buttonDrawAll.PerformClick();
        }

        private void buttonResetAll_Click(object sender, EventArgs e)
        {
            cities = new CityGraph();
            cityQueue.Clear();
            genetic = null;
            buttonDrawAll.PerformClick();
            cityCounter = 0;
        }
    }
}
