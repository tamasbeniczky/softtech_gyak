using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hajos_vizsgakerdesek
{
    public partial class FormAddNew : Form
    {
        public FormAddNew()
        {
            InitializeComponent();
        }

        private void FormAddNew_Load(object sender, EventArgs e)
        {
            FormAddNew formAddNew = new FormAddNew();
            if (formAddNew.ShowDialog() == DialogResult.OK)
            {
                kérdések.add(formAddNew.ÚjVizsgakérdés)
            }
        }
    }
}
