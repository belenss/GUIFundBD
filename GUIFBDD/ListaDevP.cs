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
    public partial class ListaDevP : Form
    {
        List<ClassDevP> DevolucionesP = new List<ClassDevP>();
        ClassDevP DevolucionP = new ClassDevP();

        public ListaDevP()
        {
            InitializeComponent();
        }

        private void LlenarDataGrid()
        {
            dgDevP.DataSource = null;
            if(DevolucionesP.Count > 0)
            {
                dgDevP.DataSource = DevolucionesP;
            }
        }

        private void ListaDevP_Load(object sender, EventArgs e)
        {
            LlenarDataGrid();
        }

        private void bNuevoDP_Click(object sender, EventArgs e)
        {
            FormDevP NuevoDevP = new FormDevP();
            if (NuevoDevP.ShowDialog() == DialogResult.OK)
            {
                DevolucionP = new ClassDevP();
                DevolucionP.FolioDP = NuevoDevP.FolioDP;
                DevolucionP.FechaDP = NuevoDevP.FechaDP;
                DevolucionP.ImporteDP = NuevoDevP.ImporteDP;
                DevolucionP.ID_R = NuevoDevP.ID_R;
                DevolucionesP.Add(DevolucionP);
                LlenarDataGrid();
            }
        }

        private void bEliminarDP_Click(object sender, EventArgs e)
        {
            DevolucionesP.RemoveAt(dgDevP.CurrentRow.Index);
            LlenarDataGrid();
        }

        private void bVolverDP_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
