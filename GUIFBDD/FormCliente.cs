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
    public partial class FormCliente : Form
    {
        public String ID_C, NombreC, DomC, TelC, CorreoC, RFCC;


        public FormCliente()
        {
            InitializeComponent();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {

        }
        private void bGuardar_Click(object sender, EventArgs e)
        {
            ID_C = txtIDC.Text;
            NombreC = txtNombreC.Text;
            DomC = txtDomicilioC.Text;
            TelC = txtTelC.Text;
            CorreoC = txtCorreoC.Text;
            RFCC = txtRFCC.Text;
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
