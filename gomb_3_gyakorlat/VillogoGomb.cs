using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gomb_3_gyakorlat
{
    internal class VillogoGomb : Button
    {
        public VillogoGomb()  /*létrehoztunk egy konstruktort a ctor tab tab-al*/
        {
            MouseEnter += VillogoGomb_MouseEnter;   /*MouseEnter += tab tab --* eseményhez rendel eseménykiszolgáó függvényt*/
            MouseLeave += VillogoGomb_MouseLeave;
        }

        private void VillogoGomb_MouseEnter(object? sender, EventArgs e)
        {
            BackColor = Color.Fuchsia;

        }
        private void VillogoGomb_MouseLeave(object? sender, EventArgs e)
        {
            BackColor = Color.Transparent;

        }

    }
}
