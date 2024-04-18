namespace Trivia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("jatek.csv"); //ezzel lehet szövegfájlokat beolvasni
            while (!sr.EndOfStream) //endofstream egy bool tipusu tulajdonsag --> akkor vesz fel igaz erteket ha vegere ertem a file beolvasasnak
            {
                string sor = sr.ReadLine();

                //string[,] tömb = new string[10,10]; //[] a tömböt jelöli | 10 elemu tombot hoz letre
                        //csak akkor adjunk meg tömb méretet ha biztos nem változik a mérete
                        //lista elemzszáma változhat
                //tömb[0, 0] = "alma"; //két dimenziós tömb

                string[] elemek = sor.Split(";");

            }


            sr.Close();
        }
    }
}
