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
    public partial class FormProveedor : Form
    {
        public String ID_P, NombreP, DomP, TelP, CorreoP, RFCP;

        public FormProveedor()
        {
            InitializeComponent();
        }
       
        private void FormProveedor_Load(object sender, EventArgs e)
        {

        }
        private void bGuardarP_Click(object sender, EventArgs e)
        {
            ID_P = txtIDP.Text;
            NombreP = txtNombreP.Text;
            DomP = txtDomicilioP.Text;
            TelP = txtTelP.Text;
            CorreoP = txtCorreoP.Text;
            RFCP = txtRFCP.Text;
            this.DialogResult = DialogResult.OK;
            Close();
        }
        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

    }
}
