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
    public partial class FormRefaccion : Form
    {
        public String ID_R, NombreR, MarcaR, PrecioR;

       

        public FormRefaccion()
        {
            InitializeComponent();
        }
        private void bGuardarR_Click(object sender, EventArgs e)
        {
            ID_R = txtIDR.Text;
            NombreR = txtNombreR.Text;
            MarcaR = txtMarca.Text;
            PrecioR = txtPrecioR.Text;
            this.DialogResult = DialogResult.OK;
            Close();
        }
        private void bCancelarR_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

       
    }
}
