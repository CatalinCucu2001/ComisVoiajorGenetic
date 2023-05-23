using ComisVoiajorGenetic.Utils;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComisVoiajorGenetic.GeneticAlgorithm
{
    internal class GeneticAlgorithmImpl
    {
        public List<Chromosome> population { get; set; }

        public GeneticAlgorithmImpl(List<Chromosome> population)
        {
            this.population = population;
        }

        public void NaturalSelection()
        {
            population = population
                .OrderBy(chromosome => chromosome.Distance)
                .Distinct(new ChromosomeEqualityComparer())
                .Take(GlobalSettings.NumberOfParentChromosomes)
                .ToList();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            population.ForEach(chromosome => sb.Append(chromosome).Append(Environment.NewLine));
            return sb.ToString();
        }
    }
}
