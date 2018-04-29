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
    public partial class FormDevP : Form
    {
        public String FolioDP, FechaDP, ImporteDP, ID_R;
        public FormDevP()
        {
            InitializeComponent();
        }

        private void bGuardarDP_Click(object sender, EventArgs e)
        {
            FolioDP = txtFolioDP.Text;
            FechaDP = txtFechaDP.Text;
            ImporteDP = txtImporteDP.Text;
            ID_R = txtIDR.Text;
            this.DialogResult = DialogResult.OK;
            Close();
        }
        private void bCancelarDP_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

    }
}
