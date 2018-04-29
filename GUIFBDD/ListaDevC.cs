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
    public partial class ListaDevC : Form
    {
        List<ClassDevC> DevolucionesC = new List<ClassDevC>();
        ClassDevC DevolucionC = new ClassDevC();

        public ListaDevC()
        {
            InitializeComponent();
        }

        private void LlenarDataGrid()
        {
            dgDevC.DataSource = null;
            if (DevolucionesC.Count > 0)
            {
                dgDevC.DataSource = DevolucionesC;
            }
        }
        private void ListaDevC_Load(object sender, EventArgs e)
        {
            LlenarDataGrid();
        }
        private void bNuevoDC_Click(object sender, EventArgs e)
        {
            FormDevC NuevoDevC = new FormDevC();
            if (NuevoDevC.ShowDialog() == DialogResult.OK)
            {
                DevolucionC = new ClassDevC();
                DevolucionC.FolioDC = NuevoDevC.FolioDC;
                DevolucionC.FechaDC = NuevoDevC.FechaDC;
                DevolucionC.ImporteDC = NuevoDevC.ImporteDC;
                DevolucionC.ID_C = NuevoDevC.ID_C;
                DevolucionesC.Add(DevolucionC);
                LlenarDataGrid();
            }
        }

        private void bEliminarDC_Click(object sender, EventArgs e)
        {
            DevolucionesC.RemoveAt(dgDevC.CurrentRow.Index);
            LlenarDataGrid();

        }

        private void bVolverDC_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
