using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComisVoiajorGenetic.GeneticAlgorithm
{
    internal class ChromosomeEqualityComparer : IEqualityComparer<Chromosome>
    {
        public bool Equals(Chromosome x, Chromosome y)
        {
            if (x == null && y == null)
                return true;

            if (x == null || y == null)
                return false;

            return x.Genes.SequenceEqual(y.Genes);
        }

        public int GetHashCode(Chromosome obj)
        {
            return obj == null ? 0 : obj.Genes.Aggregate(17, (current, gene) => current * 31 + gene.GetHashCode());
        }
    }
}
