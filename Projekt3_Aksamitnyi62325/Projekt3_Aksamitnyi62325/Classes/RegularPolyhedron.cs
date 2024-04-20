using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt3_Aksamitnyi62325.Classes
{
    public class RegularPolyhedron : Polyhedron
    {
        public RegularPolyhedron(int x, int y, float inclinationAngle, int degreeBase, int height, int width, Color color, float lineThickness, DashStyle lineStyle) : base(x, y, inclinationAngle, degreeBase, height, width, color, lineThickness, lineStyle)
        {
            this.figureName = polyhedronFigureNames.RegularPolyhedron;
            this.height = height;
            this.width = height;
            Figure figure;
            switch (degreeBase)
            {
                case 3:
                    figure = new Pyramid(x, y, 90, 3, (int)(height * 2), (int)(height * 2), color, lineThickness, lineStyle);
                    break;
                case 4:
                    figure = new Prism(x, y, 90, 4, height, (int)(height * 1.5), color, lineThickness, lineStyle);
                    break;
                case 5:
                    figure = new DoublePyramid(x, y, 90, 4, height, height * 2, color, lineThickness, lineStyle);
                    break;
                default:
                    figure = new Pyramid(x, y, 90, 3, (int)(height * 2), (int)(height * 2), color, lineThickness, lineStyle);
                    break;
            }
            this.volume = figure.volume;
            this.surfaceArea = figure.surfaceArea;
        }

        public override void Draw(Graphics g)
        {
            using (Pen pen = new Pen(color, lineThickness))
            {
                pen.DashStyle = lineStyle;
                PointF[] points = new PointF[degreeBase];
                Figure figure;

                switch (degreeBase)
                {
                    case 3:
                        figure = new Pyramid(x, y, 90, 3, (int)(height * 2), (int)(height * 2), color, lineThickness, lineStyle);
                    break;
                    case 4:
                        figure = new Prism(x, y, 90, 4, height, (int)(height * 1.5), color, lineThickness, lineStyle);
                        break;
                    case 5:
                        figure = new DoublePyramid(x, y, 90, 4, height, height * 2, color, lineThickness, lineStyle);
                    break;
                    default:
                        figure = new Pyramid(x, y, 90, 3, (int)(height * 2), (int)(height * 2), color, lineThickness, lineStyle);
                        break;
                }

                figure.Draw(g);
            }
        }

        public override void Rotate(float angleRotation, Graphics g)
        {
            using (Pen pen = new Pen(color, lineThickness))
            {
                pen.DashStyle = lineStyle;
                PointF[] points = new PointF[degreeBase];
                Figure figure;

                switch (degreeBase)
                {
                    case 3:
                        figure = new Pyramid(x, y, 90, 3, (int)(height * 2), (int)(height * 2), color, lineThickness, lineStyle);
                        break;
                    case 4:
                        figure = new Prism(x, y, 90, 4, height, (int)(height * 1.5), color, lineThickness, lineStyle);
                        break;
                    case 5:
                        figure = new DoublePyramid(x, y, 90, 4, height, height * 2, color, lineThickness, lineStyle);
                        break;
                    default:
                        figure = new Pyramid(x, y, 90, 3, (int)(height * 2), (int)(height * 2), color, lineThickness, lineStyle);
                        break;
                }

                figure.Rotate(angleRotation, g);
            }
        }
    }
}
