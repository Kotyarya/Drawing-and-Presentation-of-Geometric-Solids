using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt3_Aksamitnyi62325.Classes
{
    public class Prism : Polyhedron
    {
        public Prism(int x, int y, float inclinationAngle, int degreeBase, int height, int width, Color color, float lineThickness, DashStyle lineStyle) : base(x, y, inclinationAngle, degreeBase, height, width, color, lineThickness, lineStyle)
        {
            this.figureName = polyhedronFigureNames.Prism;


            double surfaceAreaBase = degreeBase / 2 * (width * width) * Math.Sin((Math.PI * (360 / degreeBase)) / (180));
            this.volume = (int)(surfaceAreaBase * height);
            this.surfaceArea = (int)((2 * surfaceAreaBase) + ((degreeBase * (width * Math.Sin(Math.PI / degreeBase))) * height));
        }

        public override void Draw(Graphics g)
        {
            using (Pen pen = new Pen(color, lineThickness))
            {
                pen.DashStyle = lineStyle;
                PointF[] points = new PointF[degreeBase];
                PointF[] points2 = new PointF[degreeBase];


                double radianAngle = this.inclinationAngle * (Math.PI / 180) + Math.PI;

                Point topCenter = new Point((int)(x + Math.Cos(radianAngle) * height), (int)((y + Math.Sin(radianAngle) * (height))));

                for (int i = 0; i < degreeBase; i++)
                {
                    double X = x + (width / 2) * Math.Cos((2 * Math.PI * i) / degreeBase);
                    double Y = y + (width / 4) * Math.Sin((2 * Math.PI * i) / degreeBase) + height / 2;
                    double X2 = topCenter.X + (width / 2) * Math.Cos((2 * Math.PI * i) / degreeBase);
                    double Y2 = topCenter.Y + (width / 4) * Math.Sin((2 * Math.PI * i) / degreeBase) + height / 2;

                    points[i] = new PointF((float)X, (float)Y);
                    points2[i] = new PointF((float)X2, (float)Y2);
                    g.DrawLine(pen, points[i], points2[i]);
                }

                g.DrawPolygon(pen, points);
                g.DrawPolygon(pen, points2);
            }
        }

        public override void Rotate(float angleRotation, Graphics g)
        {
            using (Pen pen = new Pen(color, lineThickness))
            {
                pen.DashStyle = lineStyle;
                PointF[] points = new PointF[degreeBase];
                PointF[] points2 = new PointF[degreeBase];


                double radianAngle = this.inclinationAngle * (Math.PI / 180) + Math.PI;
                double radianAngleRotation = 0 + angleRotation;

                Point topCenter = new Point((int)(x + Math.Cos(radianAngle) * height), (int)((y + Math.Sin(radianAngle) * (height))));

                for (int i = 0; i < degreeBase; i++)
                {
                    double X = x + (width / 2) * Math.Cos((2 * Math.PI * i + radianAngleRotation) / degreeBase);
                    double Y = y + (width / 4) * Math.Sin((2 * Math.PI * i + radianAngleRotation) / degreeBase) + height / 2;
                    double X2 = topCenter.X + (width / 2) * Math.Cos((2 * Math.PI * i + radianAngleRotation) / degreeBase);
                    double Y2 = topCenter.Y + (width / 4) * Math.Sin((2 * Math.PI * i + radianAngleRotation ) / degreeBase) + height / 2;

                    points[i] = new PointF((float)X, (float)Y);
                    points2[i] = new PointF((float)X2, (float)Y2);
                    g.DrawLine(pen, points[i], points2[i]);
                }

                g.DrawPolygon(pen, points);
                g.DrawPolygon(pen, points2);
            }
        }
    }
}
