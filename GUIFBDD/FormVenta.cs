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
    public partial class FormVenta : Form
    {
        public String FolioV, FechaV, ImporteV, ID_C;

        public FormVenta()
        {
            InitializeComponent();
        }

        private void bGuardarV_Click(object sender, EventArgs e)
        {
            FolioV = txtFolioV.Text;
            FechaV = txtFechaV.Text;
            ImporteV = txtImporteV.Text;
            ID_C = txtIDC.Text;
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void bCancelarV_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
