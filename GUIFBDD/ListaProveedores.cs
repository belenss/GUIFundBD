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
    public partial class ListaProveedores : Form
    {
        List<ClassProveedor> Proveedores = new List<ClassProveedor>();
        ClassProveedor Proveedor = new ClassProveedor();
        public ListaProveedores()
        {
            InitializeComponent();
        }

        private void LlenarDataGrid()
        {
            dgListaP.DataSource = null;
            if (Proveedores.Count > 0)
            {
                dgListaP.DataSource = Proveedores;
            }
        }

        private void ListaProveedores_Load(object sender, EventArgs e)
        {
            LlenarDataGrid();
        }

        private void bNuevoP_Click(object sender, EventArgs e)
        {
            FormProveedor NuevoP = new FormProveedor();
            if (NuevoP.ShowDialog() == DialogResult.OK)
            {
                Proveedor = new ClassProveedor();
                Proveedor.ID_P = NuevoP.ID_P;
                Proveedor.NombreP = NuevoP.NombreP;
                Proveedor.DomicilioP = NuevoP.DomP;
                Proveedor.TelP = NuevoP.DomP;
                Proveedor.CorreoP = NuevoP.CorreoP;
                Proveedor.RFCP = NuevoP.RFCP;
                Proveedores.Add(Proveedor);
                LlenarDataGrid();
            }
        }

        private void bEliminarP_Click(object sender, EventArgs e)
        {
            Proveedores.RemoveAt(dgListaP.CurrentRow.Index);
            LlenarDataGrid();
        }
        private void bVolverP_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
