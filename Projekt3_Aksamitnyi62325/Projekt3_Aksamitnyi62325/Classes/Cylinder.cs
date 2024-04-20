using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt3_Aksamitnyi62325.Classes
{
    public class Cylinder : RotatingFigure
    {

        public Cylinder(int x, int y, float inclinationAngle, int height, int width, Color color, float lineThickness, DashStyle lineStyle)
        : base(x, y, inclinationAngle, height, width, color, lineThickness, lineStyle)
        {
            this.figureName = rotatingFigureNames.Cylinder;
            this.volume = (int)((Math.PI * ((width / 2)^2)) * height);
            this.surfaceArea = (int)(2 * Math.PI * ((width / 2) ^ 2) + (2 * Math.PI * (width / 2) * height));
        }

        public override void Draw(Graphics g)
        {
            using (Pen pen = new Pen(color, lineThickness))
            {
                pen.DashStyle = lineStyle;


                double radianAngle = this.inclinationAngle * (Math.PI / 180) + Math.PI;

                Point point1 = new Point(x - (width / 2), y + (height / 2) - (width / 3));
                Point point2 = new Point((int)(point1.X + Math.Cos(radianAngle) * height),(int)((point1.Y + Math.Sin(radianAngle) * height)));

                g.DrawEllipse(pen, point1.X,point1.Y, width, width / 3);
                g.DrawEllipse(pen, point2.X, point2.Y, width, width / 3);
                g.DrawLine(pen, new Point(point1.X, point1.Y + ((width / 3) / 2)), new Point(point2.X, point2.Y + ((width / 3) / 2)));
                g.DrawLine(pen, new Point(point1.X + width, point1.Y + ((width / 3) / 2)), new Point(point2.X + width, point2.Y + ((width / 3) / 2)));

            }
        }

        public override void Rotate(float angleRotation, Graphics g)
        {
            this.Draw(g);
            using (Pen pen = new Pen(color, 1f))
            {
                pen.DashStyle = lineStyle;
                double radianAngle = 0 + angleRotation;
                double radianAngleInclination = this.inclinationAngle * (Math.PI / 180) + Math.PI;
                Point center = new Point(this.x, y + (height / 2) - (width / 3) + (width / 6));
                Point center2 = new Point((int)((x - (width / 2)) + Math.Cos(radianAngleInclination) * height) + (width / 2), (int)(((y + (height / 2) - (width / 3)) + Math.Sin(radianAngleInclination) * height) + (width / 6)));

                Point[] points = new Point[6];
                Point[] points2 = new Point[6];

                for (int i = 0; i < 6; i++)
                {
                    points[i] = new Point((int)(center.X + ((this.width / 2) * Math.Cos(radianAngle))), (int)(center.Y + ((this.width / 6) * Math.Sin(radianAngle))));
                    points2[i] = new Point((int)(center2.X + ((this.width / 2) * Math.Cos(radianAngle))), (int)(center2.Y + ((this.width / 6) * Math.Sin(radianAngle))));
                    radianAngle = radianAngle + Math.PI / 3;
                    g.DrawLine(pen, center, points[i]);
                    g.DrawLine(pen, center2, points2[i]);
                    g.DrawLine(pen, points[i], points2[i]);
                }

                g.DrawEllipse(pen, center.X - 3, center.Y - 3, 6, 6);
                g.DrawEllipse(pen, center2.X - 3, center2.Y - 3, 6, 6);


            }
        }
    }
}
