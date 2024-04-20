namespace Projekt3_Aksamitnyi62325
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RotatingFigure_Form form2 = new RotatingFigure_Form();
            this.Hide();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Polyhedrons_Form form3 = new Polyhedrons_Form();
            this.Hide();
            form3.Show();
        }
    }
}
