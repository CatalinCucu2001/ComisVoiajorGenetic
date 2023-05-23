using System;
using System.Collections.Generic;
using System.Drawing;
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

        public Color Color { get; set; }

        public float Distance { get; set; }

        public Chromosome(int size)
        {
            Genes = Enumerable.Range(0, size).ToArray();
            Color = Color.FromArgb(random.Next(200),
                random.Next(200),
                random.Next(200));
        }

        public Chromosome(int[] genes)
        {
            Genes = genes;
            Color = Color.FromArgb(random.Next(200), random.Next(200), random.Next(200));
        }

        public void Shuffle()
        {
            Genes = Genes.OrderBy(i => random.Next()).ToArray();
        }

        public Chromosome CombineWith222(Chromosome chromosome)
        {
            var childGenes1 = Enumerable.Repeat(-1, Genes.Length).ToArray();
            var crossoverPoint = random.Next(Genes.Length);

            // Fill first part of genes from first parent (this)
            for (int i = 0; i < crossoverPoint; i++)
            {
                childGenes1[i] = Genes[i];
            }

            // Fill second part of genes from second parent (chromosome)
            var index = crossoverPoint;
            for (int i = 0; i < Genes.Length && index < Genes.Length; i++)
            {
                if (!childGenes1.Contains(chromosome.Genes[i]))
                {
                    childGenes1[index++] = chromosome.Genes[i];
                }
            }

            return new Chromosome(childGenes1);
        }

        public (Chromosome, Chromosome) CombineWith(Chromosome chromosome)
        {
            var childGenes1 = Enumerable.Repeat(-1, Genes.Length).ToArray();
            var childGenes2 = Enumerable.Repeat(-1, Genes.Length).ToArray();
            var crossoverPoint = random.Next(Genes.Length);

            // Fill first part of genes
            for (int i = 0; i < crossoverPoint; i++)
            {
                childGenes1[i] = Genes[i];
                childGenes2[i] = chromosome.Genes[i];
            }

            // Fill second part of genes
            var index1 = crossoverPoint;
            var index2 = crossoverPoint;
            for (var i = 0; i < Genes.Length && index1 < Genes.Length; i++)
            {
                if (!childGenes1.Contains(chromosome.Genes[i]))
                {
                    childGenes1[index1++] = chromosome.Genes[i];
                }
            }
            for (var i = 0; i < Genes.Length && index2 < Genes.Length; i++)
            {
                if (!childGenes2.Contains(Genes[i]))
                {
                    childGenes2[index2++] = Genes[i];
                }
            }
            return (new Chromosome(childGenes1), new Chromosome(childGenes2));
        }

        public Chromosome Mutate()
        {
            var numberOfSwaps = random.Next(Genes.Length);
            var childGenes = this.Genes.Clone() as int[];
            for (var i = 0; i < numberOfSwaps; i++)
            {
                var pos1 = random.Next(Genes.Length);
                var pos2 = random.Next(Genes.Length);
                (childGenes[pos1], childGenes[pos2]) = (childGenes[pos2], childGenes[pos1]);
            }
            return new Chromosome(childGenes);
        }

        public override string ToString()
        {
            return string.Join(" ", Genes) + " -> " + Distance;
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
