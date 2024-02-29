using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gomb_3_gyakorlat
{
    internal class szamologomb : VillogoGomb
    {
        public int szam = 1;  /*Ha publicot nem irom oda vagy private-t irok ele, akkor csak ebben az osztalyban lesz elerheto a valtozo*/

        public szamologomb()
        {
            MouseClick += Szamologomb_MouseClick;       //eseménykiszolgálo
            Text = "1";
        }

        private void Szamologomb_MouseClick(object? sender, MouseEventArgs e)
        {
            //szam ++-t ide nem irhatok, mert nem egy blokkban vannak

            if (szam <6)    
            {
                szam++;
            }
            else
            {
                szam = 1;
            }
            Text = szam.ToString(); /*szamot stringe alakitja, mert szamot nem tud megjelniteni a gomb ---  TIPUSKONVERZIO*/
        }
    }
}
