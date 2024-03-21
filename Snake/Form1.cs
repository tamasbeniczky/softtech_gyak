
namespace Snake
{
    public partial class Form1 : Form
    {
        int fejX = 100;
        int fejY = 100;
        int ir�nyX = 1; // egy az x tengely ment�n jobbra
        int ir�nyY = 0; //0 a v�zszintes
        int hossz = 5;
        int l�p�ssz�m = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fejX += ir�nyX * K�gy�Elem.M�ret;
            fejY += ir�nyY * K�gy�Elem.M�ret;

            foreach (K�gy�Elem item in Controls)
            {
                if (item.Top == fejY && item.Left == fejX)
                {
                    Application.Exit();
                }
            }

            K�gy�Elem �jfej = new K�gy�Elem();
            �jfej.Left = fejX;
            �jfej.Top = fejY;
            Controls.Add(�jfej);

            if (Controls.Count > hossz) Controls.RemoveAt(0);
            if (l�p�ssz�m % 5 == 0) hossz++;
            
            l�p�ssz�m++;
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) //FELFEL�
            {
                ir�nyX = 0; //(�tl�san ne menjen a k�gy�), innent�l v�zszintesen nem megy�nk
                ir�nyY = -1;
            }

            if (e.KeyCode == Keys.S) //LEFEL�
            {
                ir�nyX = 0;
                ir�nyY = 1;
            }

            if (e.KeyCode == Keys.A) //BALRA
            {
                ir�nyX = -1;
                ir�nyY = 0;
            }

            if (e.KeyCode == Keys.D) //JOBBRA
            {
                ir�nyX = 1;
                ir�nyY = 0;
            }

        }
    }
}