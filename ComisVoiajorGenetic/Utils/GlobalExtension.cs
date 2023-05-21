using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComisVoiajorGenetic.Entity;

namespace ComisVoiajorGenetic.Utils
{
    internal static class GlobalExtension
    {
        public static float GetDistanceTo(this Point point1, Point point2)
        {
            return (float)Math.Sqrt(Math.Pow(point1.X - point2.X, 2) + Math.Pow(point1.Y - point2.Y, 2));
        }
    }
}
