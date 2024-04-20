using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt3_Aksamitnyi62325.Classes
{
    public abstract class Figure
    {
        public int x { get; protected set; }
        public int y { get; protected set; }
        public int width { get; protected set; }
        public int height { get; protected set; } 
        public float inclinationAngle { get; protected set; }
        public Color color { get; protected set; }
        public float lineThickness { get; protected set; }  
        public DashStyle lineStyle { get; protected set; }
        public bool directionRotation { get; protected set; } 
        public int surfaceArea { get; protected set; }  
        public int volume { get; protected set; }

        public int ID;

        public enum dashStyles
        {
            Solid,
            Dash,
            Dot,
            DashDot
        }

        public Figure(int x, int y, float inclinationAngle, int height, int width, Color color, float lineThickness, DashStyle lineStyle)
        {
            this.y = y;
            this.x = x; 
            this.width = width; 
            this.height = height;   
            this.inclinationAngle = inclinationAngle;
            this.color = color;
            this.lineThickness = lineThickness;
            this.lineStyle = lineStyle; 
        }

        public abstract void Draw(Graphics g);
        public abstract void Rotate(float angleRotation, Graphics g);

        public void SetNewPosition(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void SetNewGraphicsAttributes(Color color, float lineThickness, DashStyle lineStyle)
        {
            this.color = color;
            this.lineThickness = lineThickness;
            this.lineStyle = lineStyle;
        }

        public void SetNewSize(int height, int width, float inclinationAngle)
        {
            this.height = height;
            this.width = width;
            this.inclinationAngle = inclinationAngle;
        }
    }
}
