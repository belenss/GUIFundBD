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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Refacciones_Click(object sender, EventArgs e)
        {
           
            ListaRefacciones AbrirLR = new ListaRefacciones();
            AbrirLR.Show();
        }

        private void Proveedores_Click(object sender, EventArgs e)
        {
            ListaProveedores AbrirLP = new ListaProveedores();
            AbrirLP.Show();
        }

        private void Clientes_Click(object sender, EventArgs e)
        {
            ListaClientes AbrirLC = new ListaClientes();
            AbrirLC.Show();
        }

        private void Compras_Click(object sender, EventArgs e)
        {
            ListaCompras AbrirLCr = new ListaCompras();
            AbrirLCr.Show();
        }

        private void Ventas_Click(object sender, EventArgs e)
        {
            ListaVentas AbrirLV = new ListaVentas();
            AbrirLV.Show();
        }

        private void DevC_Click(object sender, EventArgs e)
        {
            ListaDevC AbrirLDC = new ListaDevC();
            AbrirLDC.Show();
        }

        private void DevP_Click(object sender, EventArgs e)
        {
            ListaDevP AbrirLDP = new ListaDevP();
            AbrirLDP.Show();
        }
    }
}
