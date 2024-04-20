using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt3_Aksamitnyi62325
{
    public partial class home_Form : Form
    {
        public home_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rotatingFigure_Button_ClickHandler(object sender, EventArgs e)
        {
            RotatingFigure_Form form2 = new RotatingFigure_Form();
            this.Hide();
            form2.Show();
        }

        private void polyhedrons_Button_ClickHandler(object sender, EventArgs e)
        {
            Polyhedrons_Form form3 = new Polyhedrons_Form();
            this.Hide();
            form3.Show();
        }
    }
}
