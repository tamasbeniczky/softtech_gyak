namespace LINQ_lekérdezések
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Kitöröljük az összes vezérlőt a panelről  
            panel1.Controls.Clear();

            // Létrehozzuk az 1. UserControlt  
            UserControl userControl1 = new UserControl1();

            // Hozzáadjuk a panelhez.  
            panel1.Controls.Add(userControl1);

            // Dock: Az objektum szülőobjektumához való illeszkedését határozza meg  
            // DockStíle.Fill: A vezérlő mind a négy oldala illeszkedjen (és méreteződjön) a szülőobjektumhoz.  
            userControl1.Dock = DockStyle.Fill;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Kitöröljük az összes vezérlőt a panelről  
            panel1.Controls.Clear();

            // Létrehozzuk az 1. UserControlt  
            UserControl userControl2 = new UserControl2();

            // Hozzáadjuk a panelhez.  
            panel1.Controls.Add(userControl2);

            // Dock: Az objektum szülőobjektumához való illeszkedését határozza meg  
            // DockStíle.Fill: A vezérlő mind a négy oldala illeszkedjen (és méreteződjön) a szülőobjektumhoz.  
            userControl2.Dock = DockStyle.Fill;
        }
    }
}