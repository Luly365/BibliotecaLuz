using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaLuz.Presentacion
{
    public partial class LibrosForm : MetroFramework.Forms.MetroForm
    {
        public LibrosForm()
        {
            InitializeComponent();
        }

        private void CerrarMetroButton_Click(object sender, EventArgs e)
        {
            
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void generosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerosForm frm = new GenerosForm();
            frm.ShowDialog(this);
        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutorForm frm = new AutorForm();
            frm.ShowDialog(this);
        }

        private void paisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaisForm frm = new PaisForm();
            frm.ShowDialog(this);
        }

        private void SalirMetroButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void editorialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditorialesForm frm = new EditorialesForm();
            frm.ShowDialog(this);
        }
    }
}
