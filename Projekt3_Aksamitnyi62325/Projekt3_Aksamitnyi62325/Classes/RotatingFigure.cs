using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt3_Aksamitnyi62325.Classes
{
    public abstract class RotatingFigure : Figure
    {


        public enum rotatingFigureNames
        {
            Cylinder,
            Cone,
            Sphere,
            DoubleCone
        }

        public rotatingFigureNames figureName { get; protected set; }

        public RotatingFigure(int x, int y, float inclinationAngle, int height, int width, Color color, float lineThickness, DashStyle lineStyle)
        : base(x, y, inclinationAngle, height, width, color, lineThickness, lineStyle)
        {
            
        }
    }
}
