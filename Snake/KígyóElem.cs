using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class KígyóElem : PictureBox
    {
        public static int Méret = 30; //public, tehát osztályon kívül is elérhető a változó -- ÉS --
                                      //statikus, tehát kígyóelempont méret változót az egész alkalmazásomból elérem
                                      //Kígyóelem osztályra lesz jellemző a változó, nem csak egy példányára

        public KígyóElem()
        {
            Width = Méret; 
            Height = Méret;
            BackColor = Color.Fuchsia;
        }
    }
}
