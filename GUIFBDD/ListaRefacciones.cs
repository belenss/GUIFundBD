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
    public partial class ListaRefacciones : Form
    {
        List<ClassRefaccion> Refacciones = new List<ClassRefaccion>();
        ClassRefaccion Refaccion = new ClassRefaccion();
        public ListaRefacciones()
        {
            InitializeComponent();
        }
        

        private void LlenarDataGrid()
        {
            dgListaR.DataSource = null;
            if (Refacciones.Count > 0)
            {
                dgListaR.DataSource = Refacciones;
            }
        }
        private void bNuevoR_Click(object sender, EventArgs e)
        {
            FormRefaccion NuevoR = new FormRefaccion();
            if (NuevoR.ShowDialog() == DialogResult.OK)
            {
                Refaccion = new ClassRefaccion();
                Refaccion.ID_R = NuevoR.ID_R;
                Refaccion.NombreR = NuevoR.NombreR;
                Refaccion.MarcaR = NuevoR.MarcaR;
                Refaccion.PrecioR = NuevoR.PrecioR;
                Refacciones.Add(Refaccion);
                LlenarDataGrid();
            }
        }
        private void bEliminarR_Click(object sender, EventArgs e)
        {
            Refacciones.RemoveAt(dgListaR.CurrentRow.Index);
            LlenarDataGrid();
        }
        private void bVolverR_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        
    }
}
