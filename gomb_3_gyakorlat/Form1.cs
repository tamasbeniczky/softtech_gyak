namespace gomb_3_gyakorlat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button b = new Button();
            Controls.Add(b);

            b.Left = ClientRectangle.Width / 2 - b.Width / 2;
            b.Top = ClientRectangle.Height / 2 - b.Height / 2;
            Random rnd = new Random();
            b.Height = 50;


            //int méret = 20; ez csak a random elott kellett

            for (int sor = 0; sor < 20; sor++)
            {
                for (int oszlop = 0; oszlop < 20; oszlop++)
                {
                    Button p = new VillogoGomb();
                    Controls.Add(p);
                    p.Height = 20;
                    p.Width = 20;
                    p.Left = rnd.Next(20,50) * oszlop;
                    p.Top = rnd.Next(10,100) * sor;

                }
            }
        }
    }
}