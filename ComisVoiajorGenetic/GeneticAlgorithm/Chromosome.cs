using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComisVoiajorGenetic.GeneticAlgorithm
{
    internal class Chromosome
    {
        private static Random random = new Random();
        public int[] Genes { get; set; }

        public Chromosome(int size)
        {
            Genes = Enumerable.Range(0, size).ToArray();
        }

        public Chromosome(int[] genes)
        {
            Genes = genes;
        }

        public void Shuffle()
        {
            Genes = Genes.OrderBy(i => random.Next()).ToArray();
        }

        public Chromosome CombineWith(Chromosome chromosome)
        {
            var childGenes = Enumerable.Repeat(-1, Genes.Length).ToArray();
            var crossoverPoint = random.Next(Genes.Length);

            // Fill first part of genes from first parent (this)
            for (int i = 0; i < crossoverPoint; i++)
            {
                childGenes[i] = Genes[i];
            }

            // Fill second part of genes from second parent (chromosome)
            var index = crossoverPoint;
            for (int i = 0; i < Genes.Length && index < Genes.Length; i++)
            {
                if (!childGenes.Contains(chromosome.Genes[i]))
                {
                    childGenes[index++] = chromosome.Genes[i];
                }
            }

            return new Chromosome(childGenes);
        }

        public Chromosome Mutate()
        {
            var numberOfSwaps = random.Next(Genes.Length);
            var childGenes = this.Genes.Clone() as int[];
            for (int i = 0; i < numberOfSwaps; i++)
            {
                var pos1 = random.Next(Genes.Length);
                var pos2 = random.Next(Genes.Length);
                (childGenes[pos1], childGenes[pos2]) = (childGenes[pos2], childGenes[pos1]);
            }
            return new Chromosome(childGenes);
        }

        public override string ToString()
        {
            return string.Join(" ", Genes);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Chromosome);
        }

        public override int GetHashCode()
        {
            return (Genes != null ? Genes.GetHashCode() : 0);
        }

        public bool Equals(Chromosome chromosome)
        {
            return Genes.SequenceEqual(chromosome.Genes);
        }
    }
}
