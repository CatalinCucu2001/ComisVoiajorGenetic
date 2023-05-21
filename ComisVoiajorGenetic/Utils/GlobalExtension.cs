using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComisVoiajorGenetic.Entity;
using ComisVoiajorGenetic.GeneticAlgorithm;

namespace ComisVoiajorGenetic.Utils
{
    internal static class GlobalExtension
    {
        public static float GetDistanceTo(this Point point1, Point point2)
        {
            return (float)Math.Sqrt(Math.Pow(point1.X - point2.X, 2) + Math.Pow(point1.Y - point2.Y, 2));
        }

        public static void Log(this TextBox textBox, GeneticAlgorithmImpl genetic)
        {
            var x = genetic.ToString();
            textBox.Text = x;
            textBox.Invalidate();
        }

        public static IEnumerable<TSource> DistinctBy<TSource, TKey>
            (this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            HashSet<TKey> seenKeys = new HashSet<TKey>();
            foreach (TSource element in source)
            {
                if (!seenKeys.Contains(keySelector(element)))
                {
                    seenKeys.Add(keySelector(element));
                    yield return element;
                }
            }
        }
    }
}
