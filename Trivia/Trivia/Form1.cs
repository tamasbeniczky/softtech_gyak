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
            StreamReader sr = new StreamReader("jatek.csv"); //ezzel lehet sz�vegf�jlokat beolvasni
            while (!sr.EndOfStream) //endofstream egy bool tipusu tulajdonsag --> akkor vesz fel igaz erteket ha vegere ertem a file beolvasasnak
            {
                string sor = sr.ReadLine();

                //string[,] t�mb = new string[10,10]; //[] a t�mb�t jel�li | 10 elemu tombot hoz letre
                        //csak akkor adjunk meg t�mb m�retet ha biztos nem v�ltozik a m�rete
                        //lista elemzsz�ma v�ltozhat
                //t�mb[0, 0] = "alma"; //k�t dimenzi�s t�mb

                string[] elemek = sor.Split(";");

            }


            sr.Close();
        }
    }
}
