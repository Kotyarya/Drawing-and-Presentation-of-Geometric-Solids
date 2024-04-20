using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt3_Aksamitnyi62325.Classes
{
    public class Sphere : RotatingFigure
    {

        public Sphere(int x, int y, float inclinationAngle, int height, int width, Color color, float lineThickness, DashStyle lineStyle)
        : base(x, y, inclinationAngle, height, width, color, lineThickness, lineStyle)
        {
            this.figureName = rotatingFigureNames.Sphere;
            this.volume = (int)((4 / 3) * Math.PI * width * width * (height / 2));
           

            if (width > height)
            {
                double e = Math.Sqrt(1 - ((height * height) / (width * width)));
                this.surfaceArea = (int)((2 * Math.PI * (width*width)) + (Math.PI * ((height*height) / e )) * Math.Log((1 + e)/(1 - e)));

            } else if (height > width)
            {
                double e = Math.Sqrt(1 - ((width * width) / (height * height)));
                this.surfaceArea = (int)((2 * Math.PI * (width * width)) * (1 + ((height) / (width * e)) * Math.Asin(e)));
            } else if (width == height) 
            {
                this.surfaceArea = (int)(4 * Math.PI * ((width / 2) * (width / 2)));
            }

        }

        public override void Draw(Graphics g)
        {
            using (Pen pen = new Pen(color, lineThickness))
            {
                pen.DashStyle = lineStyle;
                int x = this.x - (width / 2);
                int y = this.y - ((width / 3) / 2);


                g.DrawEllipse(pen, x, y, width, (width / 3));
                g.DrawEllipse(pen, this.x - (width / 2), this.y - (height / 2), width, height);
            }
        }

        public override void Rotate(float angleRotation, Graphics g)
        {
            this.Draw(g);
            using (Pen pen = new Pen(color, 1f))
            {
                pen.DashStyle = lineStyle;
                Point center = new Point(this.x, this.y);

                Point[] points = new Point[6];

                double radianAngle = 0 + angleRotation;
                for (int i = 0; i < 6; i++)
                {
                    points[i] = new Point((int)(center.X + ((this.width / 2) * Math.Cos(radianAngle))), (int)(center.Y + ((this.width / 6) * Math.Sin(radianAngle))));
                    radianAngle = radianAngle + Math.PI / 3;
                    g.DrawLine(pen, center, points[i]);
                }
 
                g.DrawEllipse(pen, this.x - 3, this.y - 3, 6, 6);
           
            }
        }
    }
}
