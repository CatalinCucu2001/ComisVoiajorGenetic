using ComisVoiajorGenetic.Entity;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComisVoiajorGenetic.Utils
{
    internal static class PictureBoxExtension
    {
        public static void DrawCity(this PictureBox pictureBox, City city, Color color)
        {
            using (Graphics gfx = Graphics.FromImage(pictureBox.Image))
            {
                int circleX = city.Location.X - (GlobalSettings.CircleRadius / 2);
                int circleY = city.Location.Y - (GlobalSettings.CircleRadius / 2);
                gfx.DrawEllipse(new Pen(color, GlobalSettings.CircleSize), circleX, circleY, GlobalSettings.CircleRadius, GlobalSettings.CircleRadius);

                SizeF numberSize = gfx.MeasureString(city.Id.ToString(), new Font("Arial", GlobalSettings.FontSize));
                float numberX = circleX + ((GlobalSettings.CircleRadius - numberSize.Width) / 2);
                float numberY = circleY + ((GlobalSettings.CircleRadius - numberSize.Height) / 2) + 2;
                gfx.DrawString(city.Id.ToString(), new Font("Arial", GlobalSettings.FontSize), new SolidBrush(color), numberX, numberY);
            }
            pictureBox.Invalidate();
        }

        public static void ClearMap(this PictureBox pictureBox)
        {
            var image = pictureBox.Image;
            using (Graphics gfx = Graphics.FromImage(image))
            {
                gfx.FillRectangle(new SolidBrush(GlobalSettings.BackgroundMapColor), 0, 0, image.Width, image.Height);
            }
        }

        public static void DrawRelation(this PictureBox pictureBox, City city1, City city2, Color color)
        {
            using (Graphics gfx = Graphics.FromImage(pictureBox.Image))
            {
                var pointA = city1.Location;
                var pointB = city2.Location;
                var distanceAB = Math.Sqrt(Math.Pow(pointB.X - pointA.X, 2) + Math.Pow(pointB.Y - pointA.Y, 2));

                // Calculate the unit vector
                var uX = (pointB.X - pointA.X) / distanceAB;
                var uY = (pointB.Y - pointA.Y) / distanceAB;

                var cX = pointA.X + (int)((GlobalSettings.CircleRadius / 2) * uX);
                var cY = pointA.Y + (int)((GlobalSettings.CircleRadius / 2) * uY);
                var newPointA = new Point(cX, cY);

                var dX = pointB.X - (int)((GlobalSettings.CircleRadius / 2) * uX);
                var dY = pointB.Y - (int)((GlobalSettings.CircleRadius / 2) * uY);
                var newPointB = new Point(dX, dY);


                gfx.DrawLine(new Pen(color, GlobalSettings.RelationSize),
                    newPointA.X, newPointA.Y,
                    newPointB.X, newPointB.Y);
            }
            pictureBox.Invalidate();
        }
        
    }
}
