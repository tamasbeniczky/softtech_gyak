namespace Pascal
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
                for (int oszlop = 1; oszlop <= 10; oszlop++)
                {
                    Button button = new Button();
                    button.Top = sor * 30;
                    button.Left = oszlop * 30;
                    button.Height = 30;
                    button.Width = 30;
                    int p = Faktorialis(sor) / (Faktorialis(oszlop) * (Faktorialis(sor - oszlop)));
                    button.Text = p.ToString();
                    if (p != 0)
                    {
                        this.Controls.Add(button);
                    }
                }
            }
        }
        int Faktorialis(int n)
        {
            int eredmény = 1;
            for (int i = 1; i <= n; i++) eredmény *= i;

            return eredmény;
        }
    }
}