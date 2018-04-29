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
    public partial class FormCompra : Form
    {
        public String FolioC, FechaC, ImporteC, ID_P;
        public FormCompra()
        {
            InitializeComponent();
        }

        private void bGuardarCr_Click(object sender, EventArgs e)
        {
            FolioC = txtFolioC.Text;
            FechaC = txtFechaC.Text;
            ImporteC = txtImporteC.Text;
            ID_P = txtIDP.Text;
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void bCancelarCr_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
