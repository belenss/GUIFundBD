using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIFBDD
{
    public partial class FormDevC : Form
    {
        public String FolioDC, FechaDC, ImporteDC, ID_C;
        public FormDevC()
        {
            InitializeComponent();
        }

        private void bGuardarDC_Click(object sender, EventArgs e)
        {
            FolioDC = txtFolioDC.Text;
            FechaDC = txtFechaDC.Text;
            ImporteDC = txtImporteDC.Text;
            ID_C = txtIDC.Text;
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void bCancelarDC_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
