using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt3_Aksamitnyi62325.Classes
{
    public class DoublePyramid : Polyhedron
    {
        public DoublePyramid(int x, int y, float inclinationAngle, int degreeBase, int height, int width, Color color, float lineThickness, DashStyle lineStyle) : base(x, y, inclinationAngle, degreeBase, height, width, color, lineThickness, lineStyle)
        {
            this.figureName = polyhedronFigureNames.DoublePyramid;


            double surfaceAreaBase = degreeBase / 2 * (width * width) * Math.Sin(Math.PI * (360 / degreeBase) / 180);
            this.volume = (int)(surfaceAreaBase * height) + (int)(surfaceAreaBase * height);
            this.surfaceArea = (int)(degreeBase * (width * Math.Sin(Math.PI / degreeBase)) * Math.Sqrt((width / 2) ^ 2 + height ^ 2) / 2 * 2);
        }

        public override void Draw(Graphics g)
        {
            using (Pen pen = new Pen(color, lineThickness))
            {
                pen.DashStyle = lineStyle;
                
                PointF[] points = new PointF[degreeBase];

                double radianAngle = this.inclinationAngle * (Math.PI / 180) + Math.PI;

                Point point = new Point((int)(x + Math.Cos(radianAngle) * height), (int)((y + Math.Sin(radianAngle) * height)));
                Point point2 = new Point((int)(x + Math.Cos(radianAngle - Math.PI) * height), (int)((y + Math.Sin(radianAngle - Math.PI) * height)));

                for (int i = 0; i < degreeBase; i++)
                {
                    double X = x + (width / 2) * Math.Cos((2 * Math.PI * i) / degreeBase);
                    double Y = y + (width / 4) * Math.Sin((2 * Math.PI * i) / degreeBase);

                    g.DrawLine(pen, (float)X, (float)Y, point.X, point.Y);

                    g.DrawLine(pen, (float)X, (float)Y, point2.X, point2.Y);
                    points[i] = new PointF((float)X, (float)Y);
                }

                g.DrawPolygon(pen, points);
            }
        }

        public override void Rotate(float angleRotation, Graphics g)
        {
            using (Pen pen = new Pen(color, lineThickness))
            {
                pen.DashStyle = lineStyle;
                PointF[] points = new PointF[degreeBase];

                double radianAngle = this.inclinationAngle * (Math.PI / 180) + Math.PI;
                double radianAngleRotation = 0 + angleRotation;

                Point point = new Point((int)(x + Math.Cos(radianAngle) * height), (int)((y + Math.Sin(radianAngle) * height)));
                Point point2 = new Point((int)(x + Math.Cos(radianAngle - Math.PI) * height), (int)((y + Math.Sin(radianAngle - Math.PI) * height)));

                for (int i = 0; i < degreeBase; i++)
                {
                    double X = x + (width / 2) * Math.Cos(((2 * Math.PI * i) + radianAngleRotation) / degreeBase);
                    double Y = y + (width / 4) * Math.Sin(((2 * Math.PI * i) + radianAngleRotation) / degreeBase);

                    g.DrawLine(pen, (float)X, (float)Y, point.X, point.Y);
                    g.DrawLine(pen, (float)X, (float)Y, point2.X, point2.Y);
                    points[i] = new PointF((float)X, (float)Y);
                }

                g.DrawPolygon(pen, points);
            }
        }
    }
}
