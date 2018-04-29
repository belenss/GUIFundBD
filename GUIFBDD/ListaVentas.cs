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
    public partial class ListaVentas : Form
    {
        List<ClassVenta> Ventas = new List<ClassVenta>();
        ClassVenta Venta = new ClassVenta();

        public ListaVentas()
        {
            InitializeComponent();
        }

        private void LlenarDataGrid()
        {
            dgListaVentas.DataSource = null;
            if (Ventas.Count > 0)
            {
                dgListaVentas.DataSource = Ventas;
            }
        }

        private void ListaVentas_Load(object sender, EventArgs e)
        {
            LlenarDataGrid();
        }

        private void bNuevoV_Click(object sender, EventArgs e)
        {
            FormVenta NuevoVenta= new FormVenta();
            if (NuevoVenta.ShowDialog() == DialogResult.OK)
            {
                Venta = new ClassVenta();
                Venta.FolioV = NuevoVenta.FolioV;
                Venta.FechaV = NuevoVenta.FechaV;
                Venta.ImporteV = NuevoVenta.ImporteV;
                Venta.ID_C = NuevoVenta.ID_C;
                Ventas.Add(Venta);
                LlenarDataGrid();
            }
        }

        private void bEliminarV_Click(object sender, EventArgs e)
        {
            Ventas.RemoveAt(dgListaVentas.CurrentRow.Index);
            LlenarDataGrid();
        }

        private void bVolverV_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
