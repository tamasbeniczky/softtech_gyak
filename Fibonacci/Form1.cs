namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Sor> sorok = new List<Sor>();

            for (int i = 0; i < 49; i++)
            {
                Sor sor = new Sor();
                sor.Sorszam = i;
                sor.Ertek = Fibonacci(i);
                sorok.Add(sor);
            }
            dataGridView1.DataSource = sorok;
        }
        int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }   
    }
}