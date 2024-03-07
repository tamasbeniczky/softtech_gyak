namespace _1_heti_feladat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            for (int s = 0; s < 10; s++)
            {
                for (int o = 0; o < 10; o++)
                {
                    VillogoGomb button = new VillogoGomb();
                    button.Height = 40;
                    button.Width = 40;
                    button.Left = o * 40;
                    button.Top = s * 40;
                    Controls.Add(button);

                    button.Text = (s*o).ToString();
                }
            }

        }
    }
}
