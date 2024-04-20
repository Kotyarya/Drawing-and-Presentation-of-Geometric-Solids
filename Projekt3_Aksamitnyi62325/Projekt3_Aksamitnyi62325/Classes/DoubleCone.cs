using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt3_Aksamitnyi62325.Classes
{
    public class DoubleCone : RotatingFigure
    {


        public DoubleCone(int x, int y, float inclinationAngle, int height, int width, Color color, float lineThickness, DashStyle lineStyle)
        : base(x, y, inclinationAngle, height, width, color, lineThickness, lineStyle)
        {
            this.figureName = rotatingFigureNames.DoubleCone;
            this.volume = (int)((1/3) * ((width / 2)^2) * (height / 2)) * 2;
            this.surfaceArea = (int)(Math.PI * (width / 2) * ((width / 2) + Math.Sqrt((height / 2)^2 + (width /2)^2))) * 2;
        }

        public override void Draw(Graphics g)
        {
            using (Pen pen = new Pen(color, lineThickness))
            {
                pen.DashStyle = lineStyle;
                double radianAngle = this.inclinationAngle * (Math.PI / 180) + Math.PI;

                Point point1 = new Point(x - (width / 2), y - (height / 2) + (width / 3));
                Point point2 = new Point((int)(x + Math.Cos(radianAngle) * height), (int)((y + Math.Sin(radianAngle) * height)));
                Point point3 = new Point((int)(x + Math.Cos(radianAngle + Math.PI) * height), (int)((y + Math.Sin(radianAngle + Math.PI) * height)));


                g.DrawEllipse(pen, point1.X, point1.Y, width, (width / 3));

                g.DrawLine(pen, new Point(point1.X, point1.Y + (width / 6)), point2);
                g.DrawLine(pen, new Point(point1.X + width, point1.Y + (width / 6)), point2);
                g.DrawLine(pen, new Point(point1.X, point1.Y + (width / 6)), point3);
                g.DrawLine(pen, new Point(point1.X + width, point1.Y + (width / 6)), point3);
            }
        }

        public override void Rotate(float angleRotation, Graphics g)
        {
            this.Draw(g);
            using (Pen pen = new Pen(color, 1f))
            {
                pen.DashStyle = lineStyle;
                double radianAngleForInclination = this.inclinationAngle * (Math.PI / 180) + Math.PI;
                Point center = new Point(this.x, y - (height / 2) + (width / 3) + (width / 6));
                Point point = new Point((int)(x + Math.Cos(radianAngleForInclination) * height), (int)((y + Math.Sin(radianAngleForInclination) * height)));
                Point point2 = new Point((int)(x + Math.Cos(radianAngleForInclination + Math.PI) * height), (int)((y + Math.Sin(radianAngleForInclination + Math.PI) * height)));

                Point[] points = new Point[6];

                double radianAngle = 0 + angleRotation;
                for (int i = 0; i < 6; i++)
                {
                    points[i] = new Point((int)(center.X + ((this.width / 2) * Math.Cos(radianAngle))), (int)(center.Y + ((this.width / 6) * Math.Sin(radianAngle))));
                    radianAngle = radianAngle + Math.PI / 3;
                    g.DrawLine(pen, center, points[i]);
                    g.DrawLine(pen, points[i], point);
                    g.DrawLine(pen, points[i], point2);
                }

                g.DrawEllipse(pen, center.X - 3, center.Y - 3, 6, 6);

            }
        }
    }
}
