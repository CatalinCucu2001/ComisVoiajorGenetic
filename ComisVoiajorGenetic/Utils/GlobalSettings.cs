using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComisVoiajorGenetic.Utils
{
    internal static class GlobalSettings
    {
        // GlobalSettings
        public static int CircleRadius = 45;
        public static int CircleSize = 8;
        public static int FontSize = 16;
        public static string CityPrefixName = "City";
        public static int MinimumDistanceBetweenCities = 75;
        public static int SelectCityRange = 28;
        public static Color BackgroundMapColor = Color.White;
        public static Color DefaultCircleColor = Color.Black;
        public static Color SelectedCircleColor = Color.Coral;
        public static Color DefaultRelationColor = Color.FromArgb(25, 25, 25);
        public static int RelationSize = 5;
    }
}
