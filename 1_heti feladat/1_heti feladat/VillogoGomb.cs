using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_heti_feladat
{
    internal class VillogoGomb : Button
    {
        public VillogoGomb()
        {
            BackColor = Color.Fuchsia;
            MouseEnter += VillogoGomb_MouseEnter;
            MouseLeave += VillogoGomb_MouseLeave;
        }

        private void VillogoGomb_MouseLeave(object? sender, EventArgs e)
        {
            BackColor = SystemColors.ButtonFace;
        }

        private void VillogoGomb_MouseEnter(object? sender, EventArgs e)
        {
            BackColor = Color.Yellow;
        }

    
    }
}
