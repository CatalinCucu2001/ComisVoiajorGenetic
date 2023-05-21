using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComisVoiajorGenetic.GeneticAlgorithm
{
    internal class ChromosomeComparer : IEqualityComparer<Chromosome>
    {
        public bool Equals(Chromosome x, Chromosome y)
        {
            if (ReferenceEquals(x, y)) return true;
            if (ReferenceEquals(x, null)) return false;
            if (ReferenceEquals(y, null)) return false;
            if (x.GetType() != y.GetType()) return false;
            return x.Genes.SequenceEqual(y.Genes);
        }

        public int GetHashCode(Chromosome obj)
        {
            return (obj.Genes != null ? obj.Genes.GetHashCode() : 0);
        }
    }
}
