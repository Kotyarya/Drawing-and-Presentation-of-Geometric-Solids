using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Projekt3_Aksamitnyi62325.Classes
{
    public class Script
    {

        public Graphics g { get; private set; }
        public PictureBox pic { get; private set; }
        public Bitmap bmp { get; private set; }
        public uint currentIndex { get; private set; } = 1;
        public Timer timer { get; private set; }
        public NumericUpDown numeric { get; private set; }
        public List<int> modifiedFiguresIndexes { get; private set; } = new List<int>();
        public bool presentationIsTurn { get; private set; } = false;
        public List<Figure> figuresList { get; private set; }
        public List<Figure> deleteFiguresList { get; private set; }
        public float stepRotate { get; private set; } = 0;
        public bool directionRotation = false;
        public Figure currentFigure { get; private set; }
        public bool isShowDrawing = false;
        public Graphics tempG { get; private set; }
        public bool isASC { get; private set; } = true;
        public string sortBy { get; private set; } = "Height";

        Bitmap tempBM;
        Bitmap tempBMView;
        Graphics tempGView;
        Polyhedron figureView;



        public Script(Graphics g, PictureBox pic, Bitmap bmp, NumericUpDown numeric)
        {
            this.g = g;
            this.pic = pic;
            this.bmp = bmp;
            this.numeric = numeric;
            figuresList = new List<Figure>();
            deleteFiguresList = new List<Figure>(); 
            timer = new Timer();
            tempBM = new Bitmap(pic.Width, pic.Height);

        }


        public void DrawAll()
        {
            presentationIsTurn = false;
            foreach (Figure figure in figuresList)
            {
                figure.Draw(g);
            }
            pic.Image = bmp;
            isShowDrawing = false;
        }

        public void SetNewBackColor(Color color)
        {
            pic.BackColor = color;
            g.Clear(pic.BackColor);
            if (!presentationIsTurn)
            {
                DrawAll();
            }
            else
            {
                SetCurrentIndex(currentIndex);
            }
        }

        public void AddFigure(string nameFigure, int x, int y, float inclinationAngle, int height, int width, Color color, float lineThickness, string lineStyleName, int degreeBase = 0)
        {
            Figure figure;
            DashStyle lineStyle;

            switch (lineStyleName)
            {
                case "Solid":
                    lineStyle = DashStyle.Solid; break;
                case "Dash": 
                    lineStyle = DashStyle.Dash; break;
                case "Dot":
                    lineStyle = DashStyle.Dot; break;
                case "DashDot":
                    lineStyle = DashStyle.DashDot; break;
                default:
                    lineStyle = DashStyle.Solid; break;
            }

            switch (nameFigure)
            {
                case "Sphere":
                    figure = new Sphere(x,y,inclinationAngle,height,width,color,lineThickness,lineStyle);
                    break;
                case "Cone":
                    figure = new Cone(x, y, inclinationAngle, height, width, color, lineThickness, lineStyle);
                    break;
                case "Cylinder":
                    figure = new Cylinder(x, y, inclinationAngle, height, width, color, lineThickness, lineStyle);
                    break;
                case "DoubleCone":
                    figure = new DoubleCone(x, y, inclinationAngle, height / 2, width, color, lineThickness, lineStyle);
                    break;
                case "Pyramid":
                    figure = new Pyramid(x, y, inclinationAngle, degreeBase, height, width, color, lineThickness, lineStyle);
                    break;
                case "Prism":
                    figure = new Prism(x, y, inclinationAngle, degreeBase, height, width, color, lineThickness, lineStyle);
                    break;
                case "DoublePyramid":
                    figure = new DoublePyramid(x, y, inclinationAngle, degreeBase, height / 2, width, color, lineThickness, lineStyle);
                    break;
                case "RegularPolyhedron":
                    figure = new RegularPolyhedron(x, y, inclinationAngle, degreeBase, height / 2, width, color, lineThickness, lineStyle);
                    break;
                default:
                    figure = new Sphere(x, y, inclinationAngle, height, width, color, lineThickness, lineStyle);
                    break;
            }

            figure.ID = figuresList.Count;
            figuresList.Add(figure);
            numeric.Maximum = figuresList.Count;
            DrawAll();
        }

        public void RotateAll(bool agreeRotation = true) 
        {
                g.Clear(pic.BackColor);

                if (!isShowDrawing && figuresList.Count == 0)
                {
                    pic.Image = bmp;
                    pic.BackgroundImage = null;
                }

                if (stepRotate >= Math.PI * 2)
                {
                    stepRotate = 0;
                }

                if (presentationIsTurn)
                {
                    Point position = new Point(currentFigure.x, currentFigure.y);
                    currentFigure.SetNewPosition(pic.Width / 2, pic.Height / 2);
                    currentFigure.Rotate(stepRotate, g);
                    figuresList[(int)currentIndex - 1].SetNewPosition(position.X, position.Y);


                }
                else
                {
                    for (int i = 0; i < figuresList.Count; i++)
                    {
                        figuresList[i].Rotate(agreeRotation ? stepRotate : 0, g);
                    }
                }


                if (directionRotation)
                {
                    stepRotate = stepRotate + (float)(Math.PI / 30);
                }
                else
                {
                    stepRotate = stepRotate - (float)(Math.PI / 30);
                }

                pic.Image = bmp;
            
        }

        public void Sort(bool isASC, string sortBy)
        {
            this.isASC = isASC;
            this.sortBy = sortBy;
            figuresList.Sort(new FigureComparer(isASC, sortBy));
        }

        public void SetCurrentIndex(uint currentIndex)
        {

            presentationIsTurn = true;
            this.currentIndex = currentIndex;
            numeric.Value = currentIndex;
            g.Clear(pic.BackColor);

            currentFigure = figuresList[(int)currentIndex - 1];

            Point position = new Point(currentFigure.x, currentFigure.y);

            currentFigure.SetNewPosition(pic.Width/2,pic.Height/2);
            currentFigure.Draw(g);
            pic.Image = bmp;
            figuresList[(int)currentIndex - 1].SetNewPosition(position.X, position.Y);  
        }

        public void Next()
        {
            if (currentIndex == figuresList.Count)
            {
                SetCurrentIndex(1);
            }
            else
            {
                SetCurrentIndex(currentIndex + 1);
            }
        }

        public void Previous() 
        {
            if (currentIndex == 1)
            {
                SetCurrentIndex((uint)figuresList.Count);
            }
            else
            {
                SetCurrentIndex(currentIndex - 1);
            }
        }

        public void ShowDrawing(string nameFigure, int x, int y, float inclinationAngle, int height, int width, Color color, float lineThickness, string lineStyleName, int degreeBase = 0)
        {
            if (!isShowDrawing)
            {
                return;
            }
            Figure figure;
            DashStyle lineStyle;

            switch (lineStyleName)
            {
                case "Solid":
                    lineStyle = DashStyle.Solid; break;
                case "Dash":
                    lineStyle = DashStyle.Dash; break;
                case "Dot":
                    lineStyle = DashStyle.Dot; break;
                case "DashDot":
                    lineStyle = DashStyle.DashDot; break;
                default:
                    lineStyle = DashStyle.Solid; break;
            }

            switch (nameFigure)
            {
                case "Sphere":
                    figure = new Sphere(x, y, inclinationAngle, height, width, color, lineThickness, lineStyle);
                    break;
                case "Cone":
                    figure = new Cone(x, y, inclinationAngle, height, width, color, lineThickness, lineStyle);
                    break;
                case "Cylinder":
                    figure = new Cylinder(x, y, inclinationAngle, height, width, color, lineThickness, lineStyle);
                    break;
                case "DoubleCone":
                    figure = new DoubleCone(x, y, inclinationAngle, height / 2, width, color, lineThickness, lineStyle);
                    break;
                case "Pyramid":
                    figure = new Pyramid(x, y, inclinationAngle, degreeBase, height, width, color, lineThickness, lineStyle);
                    break;
                case "Prism":
                    figure = new Prism(x, y, inclinationAngle, degreeBase, height, width, color, lineThickness, lineStyle);
                    break;
                case "DoublePyramid":
                    figure = new DoublePyramid(x, y, inclinationAngle, degreeBase, height / 2, width, color, lineThickness, lineStyle);
                    break;
                case "RegularPolyhedron":
                    figure = new RegularPolyhedron(x, y, inclinationAngle, degreeBase, height / 2, width, color, lineThickness, lineStyle);
                    break;
                default:
                    figure = new Sphere(x, y, inclinationAngle, height, width, color, lineThickness, lineStyle);
                    break;
            }



            pic.BackgroundImage = bmp;
            tempBM = new Bitmap(pic.Width, pic.Height);
            tempG = Graphics.FromImage(tempBM);
            figure.Draw(tempG);
            pic.Image = tempBM;
        }

        public void StartAutomaticPresentation()
        {
            SetCurrentIndex(1);
            timer = new Timer();
            timer.Interval = 1000;
            timer.Start();
            timer.Tick += Timer_Tick;
        }

        public void StopPresentation()
        {
            timer.Stop();
            timer.Dispose();
            SetCurrentIndex(1);
            DrawAll();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Next();
        }

        public void DeleteCurrentFigure()
        {
            figuresList.RemoveAt((int)currentIndex - 1);

            Previous();
        }

        public void SetNewAttributes(Color color, float lineThckness, string lineStyleName, int height, int weight, float inclinationAngle, int degreeBase = 0)
        {
            if (!presentationIsTurn)
            {
                return;
            }
            DashStyle lineStyle;

            switch (lineStyleName)
            {
                case "Solid":
                    lineStyle = DashStyle.Solid; break;
                case "Dash":
                    lineStyle = DashStyle.Dash; break;
                case "Dot":
                    lineStyle = DashStyle.Dot; break;
                case "DashDot":
                    lineStyle = DashStyle.DashDot; break;
                default:
                    lineStyle = DashStyle.Solid; break;
            }
            currentFigure.SetNewGraphicsAttributes(color, lineThckness, lineStyle);
            currentFigure.SetNewSize(height, weight, inclinationAngle);

            if (currentFigure is Polyhedron polyhedron)
            {
                polyhedron.SetNewDegreeBase(degreeBase);
            }

            SetCurrentIndex(currentIndex);
        }

        public void Undo() 
        {
            figuresList.Sort(new FigureComparer(true, "ID"));
            Figure lastFigure = figuresList[figuresList.Count - 1];

            deleteFiguresList.Add(lastFigure);

            figuresList.RemoveAt(figuresList.Count - 1);
            figuresList.Sort(new FigureComparer(isASC, sortBy));
            DrawAll();
        }

        public void Redo()
        {
            deleteFiguresList.Sort(new FigureComparer(false, "ID"));
            Figure lastFigure = deleteFiguresList[deleteFiguresList.Count - 1];

            figuresList.Add(lastFigure);

            deleteFiguresList.RemoveAt(deleteFiguresList.Count - 1);
            figuresList.Sort(new FigureComparer(isASC, sortBy));
            DrawAll();
        }

        public void DrawView(PictureBox pic, string nameFigure)
        {
            tempBMView = new Bitmap(pic.Width, pic.Height);
            tempGView = Graphics.FromImage(tempBMView);
            tempGView.Clear(Color.White);

            Figure figure = figuresList[figuresList.Count - 1];

            if (presentationIsTurn)
            {
                figure = currentFigure;
            }

            int x = (pic.Width / 2) - 15;
            int y = (pic.Height / 2) - 15;
            float inclinationAngle = figure.inclinationAngle;
            int degreeBase;
            Color color = figure.color;
            float lineThickness = figure.lineThickness;
            DashStyle lineStyle = figure.lineStyle;
            int height = figure.height;
            int width = figure.width;

            if (figure is Polyhedron polyhedron)
            {
                degreeBase = polyhedron.degreeBase;
            } else
            {
                degreeBase = 3;
            }

            if (height >= width)
            {
                double coefficient = (double)(pic.Height - 50) / (double)height;
                height = pic.Height - 50;
                width = (int)(width * coefficient);

            } else if (width >= height)
            {
                double coefficient = (double)(pic.Width - 50) / (double)width;
                width = pic.Width - 50;
                height = (int)(height * (coefficient / 2));
            }


            switch (nameFigure)
            {
                case "Pyramid":
                    figureView = new Pyramid(x, y, inclinationAngle, degreeBase, height, width, color, lineThickness, lineStyle);
                    break;
                case "Prism":
                    figureView = new Prism(x, y, inclinationAngle, degreeBase, height, width, color, lineThickness, lineStyle);
                    break;
                case "DoublePyramid":
                    figureView = new DoublePyramid(x, y, inclinationAngle, degreeBase, height / 2, width, color, lineThickness, lineStyle);
                    break;
                case "RegularPolyhedron":
                    figureView = new RegularPolyhedron(x, y, inclinationAngle, degreeBase, height / 2, width, color, lineThickness, lineStyle);
                    break;
                default:
                    figureView = new Pyramid(x, y, inclinationAngle, degreeBase, height, width, color, lineThickness, lineStyle);
                    break;
            }

            figureView.Draw(tempGView);

            pic.Image = tempBMView;
        }


        public void RotateView(float rotateAngle, PictureBox picture)
        {
            if (figureView != null)
            {
                tempGView.Clear(Color.White);
                figureView.Rotate(rotateAngle, tempGView);
                picture.Image = tempBMView;
            }
        }
    }
}
