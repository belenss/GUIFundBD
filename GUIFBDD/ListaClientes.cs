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
    public partial class ListaClientes : Form
    {
        List<ClassCliente> Clientes = new List<ClassCliente>();
        ClassCliente Cliente = new ClassCliente();
        public ListaClientes()
        {
            InitializeComponent();

        }
        
        private void LlenarDataGrid()
        {
            dgListaC.DataSource = null;
            if(Clientes.Count > 0)
            {
                dgListaC.DataSource = Clientes;
            }
        }
        private void ListaClientes_Load(object sender, EventArgs e)
        {
            LlenarDataGrid();
        }

        private void bNuevoC_Click(object sender, EventArgs e)
        {
            FormCliente NuevoC = new FormCliente();
            if (NuevoC.ShowDialog() == DialogResult.OK)
            {
                Cliente = new ClassCliente();
                Cliente.ID_C = NuevoC.ID_C;
                Cliente.NombreC = NuevoC.NombreC;
                Cliente.DomicilioC = NuevoC.DomC;
                Cliente.TelC = NuevoC.TelC;
                Cliente.CorreoC = NuevoC.CorreoC;
                Cliente.RFCC = NuevoC.RFCC;
                Clientes.Add(Cliente);
                LlenarDataGrid();

            }
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            Clientes.RemoveAt(dgListaC.CurrentRow.Index);
            LlenarDataGrid();
        }

        private void bVolverC_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgListaC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
