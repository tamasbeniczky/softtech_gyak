
namespace Snake
{
    public partial class Form1 : Form
    {
        int fejX = 100;
        int fejY = 100;
        int irányX = 1; // egy az x tengely mentén jobbra
        int irányY = 0; //0 a vízszintes
        int hossz = 5;
        int lépésszám = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fejX += irányX * KígyóElem.Méret;
            fejY += irányY * KígyóElem.Méret;

            foreach (KígyóElem item in Controls)
            {
                if (item.Top == fejY && item.Left == fejX)
                {
                    Application.Exit();
                }
            }

            KígyóElem újfej = new KígyóElem();
            újfej.Left = fejX;
            újfej.Top = fejY;
            Controls.Add(újfej);

            if (Controls.Count > hossz) Controls.RemoveAt(0);
            if (lépésszám % 5 == 0) hossz++;
            
            lépésszám++;
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) //FELFELÉ
            {
                irányX = 0; //(átlósan ne menjen a kígyó), innentõl vízszintesen nem megyünk
                irányY = -1;
            }

            if (e.KeyCode == Keys.S) //LEFELÉ
            {
                irányX = 0;
                irányY = 1;
            }

            if (e.KeyCode == Keys.A) //BALRA
            {
                irányX = -1;
                irányY = 0;
            }

            if (e.KeyCode == Keys.D) //JOBBRA
            {
                irányX = 1;
                irányY = 0;
            }

        }
    }
}