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
    public partial class ListaCompras : Form
    {
        List<ClassCompra> Compras = new List<ClassCompra>();
        ClassCompra Compra = new ClassCompra();

        public ListaCompras()
        {
            InitializeComponent();
        }

        private void LlenarDataGrid()
        {
            dgListaCr.DataSource = null;
            if (Compras.Count > 0)
            {
                dgListaCr.DataSource = Compras;
            }
        }
        private void ListaCompras_Load(object sender, EventArgs e)
        {
            LlenarDataGrid();
        }
        private void bNuevoCr_Click(object sender, EventArgs e)
        {
            FormCompra NuevoCompra = new FormCompra();
            if (NuevoCompra.ShowDialog() == DialogResult.OK)
            {
                Compra = new ClassCompra();
                Compra.FolioC = NuevoCompra.FolioC;
                Compra.FechaC = NuevoCompra.FechaC;
                Compra.ImporteC = NuevoCompra.ImporteC;
                Compra.ID_P = NuevoCompra.ID_P;
                Compras.Add(Compra);
                LlenarDataGrid();
            }
        }

        private void bEliminarCr_Click(object sender, EventArgs e)
        {
            Compras.RemoveAt(dgListaCr.CurrentRow.Index);
            LlenarDataGrid();
        }
        private void bVolverCr_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        
    }
}
