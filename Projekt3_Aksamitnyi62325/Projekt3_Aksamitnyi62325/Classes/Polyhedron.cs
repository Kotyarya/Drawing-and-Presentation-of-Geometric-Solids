using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt3_Aksamitnyi62325.Classes
{
    public abstract class Polyhedron : Figure
    {


        public enum polyhedronFigureNames
        {
            Pyramid,
            Prism,
            RegularPolyhedron,
            DoublePyramid,
        }

        public polyhedronFigureNames figureName { get; protected set; }

        public int degreeBase {  get; protected set; }

        public Polyhedron(int x, int y, float inclinationAngle, int degreeBase, int height, int width, Color color, float lineThickness, DashStyle lineStyle) : base(x, y, inclinationAngle, height, width, color, lineThickness, lineStyle)
        {
            this.degreeBase = degreeBase;
        }

        public void SetNewDegreeBase( int degreeBase)
        { 
            this.degreeBase = degreeBase;
        }
    }
}
