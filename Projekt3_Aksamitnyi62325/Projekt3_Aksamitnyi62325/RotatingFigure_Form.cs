using Projekt3_Aksamitnyi62325.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt3_Aksamitnyi62325
{
    public partial class RotatingFigure_Form : Form
    {
        public RotatingFigure_Form()
        {
            InitializeComponent();
            bm = new Bitmap(pictureBox.Width, pictureBox.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pictureBox.Image = bm;
        }

        Bitmap bm;
        Graphics g;
        Script script;
        int x;
        int y;
        string sortBy = "Height";
        bool isChangeAttributes = false;


        private void Polyhedrons_Form_LoadHandler(object sender, EventArgs e)
        {
            string[] figureNames = Enum.GetNames(typeof(RotatingFigure.rotatingFigureNames)) as string[];
            string[] lineStyleNames = Enum.GetNames(typeof(Figure.dashStyles)) as string[];

            for (int i = 0; i < figureNames.Length; i++)
            {
                selectFigure_ComboBox.Items.Add(figureNames[i]);
                selectFigure_ComboBox.Text = figureNames[0];
            }

            for (int i = 0; i < lineStyleNames.Length; i++)
            {
                lineStyle_ComboBox.Items.Add(lineStyleNames[i]);
                lineStyle_ComboBox.Text = lineStyleNames[0];
            }

            height_TrackBar.Maximum = pictureBox.Height - 100;
            width_TrackBar.Maximum = pictureBox.Width - 100;

            this.MinimizeBox = false;
            this.MaximizeBox = false;

            bm = new Bitmap(pictureBox.Width, pictureBox.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pictureBox.Image = bm;
            script = new Script(g, pictureBox, bm, figureIndex_Numeric);
            Draw();
        }

        private void Polyhedrons_Form_CloseHandler(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pic_MouseClickHandler(object sender, MouseEventArgs e)
        {
            rotateTimer_Timer.Stop();
            if (script.isShowDrawing)
            {
                script.AddFigure(selectFigure_ComboBox.Text, e.X, e.Y, inclinationAngle_TrackBar.Value, height_TrackBar.Value, width_TrackBar.Value, color_Button.BackColor, (float)lineThickness_Numeric.Value, lineStyle_ComboBox.Text);
                onPresentation_Button.Enabled = true;
                undo_Button.Enabled = true;
            }
            function_Button.Text = "Add";


            rotateTimer_Timer.Start();

        }

        private void rotateTimer_Timer_TickHandler(object sender, EventArgs e)
        {
            if (!script.isShowDrawing)
            {
                script.RotateAll();
            }
        }

        private void changeDirection_Button_ClickHadler(object sender, EventArgs e)
        {
            script.directionRotation = !script.directionRotation;
        }

        private void onPresentation_Button_ClickHandler(object sender, EventArgs e)
        {

            if (manual_RadioButton.Checked)
            {
                script.SetCurrentIndex(1);

            } else
            {
                script.StartAutomaticPresentation();
            }

            StartPresentation();
            RefreshFigureData();

        }

        public void RefreshFigureData()
        {

            RotatingFigure figure;

            for (int i = 0; i < figureAttributes_GroupBox.Controls.Count; i++)
            {
                figureAttributes_GroupBox.Controls[i].Enabled = false;
            }

            function_Button.Enabled = true;
            function_Button.Text = "Change attributes";
            isChangeAttributes = false;

            if (script.currentFigure is RotatingFigure rotatingFigure) 
            {
                figure = rotatingFigure;
                height_TrackBar.Value = figure.height;
                width_TrackBar.Value = figure.width;
                inclinationAngle_TrackBar.Value = (int)figure.inclinationAngle;
                lineStyle_ComboBox.Text = figure.lineStyle.ToString();
                color_Button.BackColor = figure.color;
                selectFigure_ComboBox.Text = figure.figureName.ToString();
                lineThickness_Numeric.Value = (int)figure.lineThickness;
                width_Label.Text = "Width : " + width_TrackBar.Value;
                height_Label.Text = "Height : " + height_TrackBar.Value;
                inclinationAngle_Label.Text = "Inclination angle\r\nof the figure : " + inclinationAngle_TrackBar.Value + "°";
            }
        }

        private void figureIndex_Numeric_ValueChangedHandler(object sender, EventArgs e)
        {
            script.SetCurrentIndex((uint)figureIndex_Numeric.Value);

            RefreshFigureData();    
        }

        private void offPresentation_Button_ClickHandler(object sender, EventArgs e)
        {
            script.StopPresentation();
            StopPresentation();
        }

        private void previous_Button_ClickHandler(object sender, EventArgs e)
        {
            script.Previous();

            RefreshFigureData();
        }

        private void next_Button_ClickHandler(object sender, EventArgs e)
        {
            script.Next();

            RefreshFigureData();
        }

        private void sort_RadioButton_ClickHandler(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked) 
            {
                if ((string)radioButton.Tag == "Sort")
                {
                    sortBy = radioButton.Text;
                }
                script.Sort(asc_RadioButton.Checked, sortBy);
            }
        }

        private void ChangeAttributes(object sender, EventArgs e)
        {
            

            width_Label.Text = "Width : " + width_TrackBar.Value;
            height_Label.Text = "Height : " + height_TrackBar.Value;
            inclinationAngle_Label.Text = "Inclination angle\r\nof the figure : " + inclinationAngle_TrackBar.Value + "°";

            if (sender is Button)
            {
                ColorDialog colorDialog = new ColorDialog();

                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    color_Button.BackColor = colorDialog.Color;
                }
            }

            if (isChangeAttributes)
            {
                script.SetNewAttributes(color_Button.BackColor, (float)lineThickness_Numeric.Value, lineStyle_ComboBox.Text, height_TrackBar.Value, width_TrackBar.Value, inclinationAngle_TrackBar.Value);
            }
        }

        private void changeBackground_Button_ClickHandler(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                script.SetNewBackColor(colorDialog.Color);
            }
        }

        private void pic_MouseMoveHandler(object sender, MouseEventArgs e)
        {
            x = e.X; y = e.Y;
            script.ShowDrawing(selectFigure_ComboBox.Text, x, y, inclinationAngle_TrackBar.Value, height_TrackBar.Value, width_TrackBar.Value, color_Button.BackColor, (float)lineThickness_Numeric.Value, lineStyle_ComboBox.Text);
        }

        private void pic_MouseLeaveHandler(object sender, EventArgs e)
        {
            rotateTimer_Timer.Start();
        }

        private void function_Button_ClickHandler(object sender, EventArgs e)
        {
            if (!script.presentationIsTurn)
            {
                script.isShowDrawing = !script.isShowDrawing;
                if (script.isShowDrawing)
                {
                    function_Button.Text = "Delete";
                }
                else
                {
                    function_Button.Text = "Add";
                }
            } else
            {
                isChangeAttributes = true;
                for (int i = 0; i < figureAttributes_GroupBox.Controls.Count; i++)
                {
                    figureAttributes_GroupBox.Controls[i].Enabled = true;
                }

            }
        }

        private void reset_Button_ClickHandler(object sender, EventArgs e)
        {
            bm = new Bitmap(pictureBox.Width, pictureBox.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pictureBox.Image = bm;
            script = new Script(g, pictureBox, bm, figureIndex_Numeric);
            onPresentation_Button.Enabled = false;
        }

        private void deleteFigure_Button_ClickHandler(object sender, EventArgs e)
        {
            script.DeleteCurrentFigure();   
        }

        private void undo_Button_ClickHandler(object sender, EventArgs e)
        {
          
            if (script.figuresList.Count > 0)
            {
                script.Undo();
                redo_Button.Enabled = true;
            }

            if (script.figuresList.Count < 1)
            {
                undo_Button.Enabled = false;
            }
        }

        private void redo_Button_ClickHandler(object sender, EventArgs e)
        {

            if (script.deleteFiguresList.Count > 0)
            {
                script.Redo();
                undo_Button.Enabled = true;
            }

            if (script.deleteFiguresList.Count == 0)
            {
                redo_Button.Enabled = false;
            }
        }

        public void Draw()
        {
            figureIndex_GroupBox.Enabled = false;
            previous_Button.Enabled = false;
            next_Button.Enabled = false;
            offPresentation_Button.Enabled = false;   
            deleteFigure_Button.Enabled = false;
            onPresentation_Button.Enabled = false;
            selectFigure_ComboBox.Enabled = true;
        }

        public void StartPresentation()
        {
            selectFigure_ComboBox.Enabled = false;
            figureIndex_GroupBox.Enabled = true;
            sort_GroupBox.Enabled = false;
            arrange_GroupBox.Enabled = false;
            deleteFigure_Button.Enabled = true;
            undoRedo_GroupBox.Enabled = false;
            previous_Button.Enabled = true;
            next_Button.Enabled = true;
            offPresentation_Button.Enabled = true;
            onPresentation_GroupBox.Enabled = false;
            reset_Button.Enabled = false;

            if (automatic_RadioButton.Checked)
            {
                previous_Button.Enabled = false;  
                next_Button.Enabled = false;
                figureIndex_GroupBox.Enabled = false;
                deleteFigure_Button.Enabled = false;
                figureAttributes_GroupBox.Enabled = false;
            }
        }

        public void StopPresentation()
        {
            Draw();

            sort_GroupBox.Enabled = true;
            arrange_GroupBox.Enabled = true;
            onPresentation_GroupBox.Enabled = true;
            onPresentation_Button.Enabled = true;
            undoRedo_GroupBox.Enabled = true;
            reset_Button.Enabled = true;
            function_Button.Text = "Add";
            figureAttributes_GroupBox.Enabled = true;
            for (int i = 0; i < figureAttributes_GroupBox.Controls.Count; i++)
            {
                figureAttributes_GroupBox.Controls[i].Enabled = true;
            }
        }
    }
}
