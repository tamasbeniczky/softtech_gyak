namespace Szorzotabla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int sor = 1; sor < 10; sor++)
            {
                for (int oszlop = 1; oszlop < 10; oszlop++)
                {
                    Button button = new Button();
                    button.Text = (sor * oszlop).ToString();
                    button.Size = new Size(40, 40);
                    button.Location = new Point(40 * oszlop, 40 * sor);
                    this.Controls.Add(button);
                }
            }
        }
    }
}