using BibliotecaLuz.Entidades.Entities;
using BibliotecaLuz.Servicios;
using MetroFramework;
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
    public partial class AutorForm : MetroFramework.Forms.MetroForm

    {
        public AutorForm()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void SalirMetroButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private ServicioAutor servicio;
        List<Autor> lista;
        private void AutorForm_Load(object sender, EventArgs e)
        {
            try
            {
                servicio = new ServicioAutor();
                lista = servicio.GetAutor();
                MostraDatosEnGrilla();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void MostraDatosEnGrilla()
        {
            AutorMetroGrid.Rows.Clear();
            foreach (var autor in lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, autor);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            AutorMetroGrid.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Autor autor)
        {
            r.Cells[cmnAutor.Index].Value = autor.NombreAutor;
            

            r.Tag = autor;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(AutorMetroGrid);
            return r;
        }
        //borrar//
        private void BorrarMetroButton_Click(object sender, EventArgs e)
        {
            if (AutorMetroGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow r = AutorMetroGrid.SelectedRows[0];
                Autor autor = (Autor)r.Tag;
                DialogResult dr = MessageBox.Show($"¿Desea dar de baja al Autor {autor.NombreAutor}?",
                    "Confirmar Baja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    servicio.Borrar(autor.AutorId);
                    AutorMetroGrid.Rows.Remove(r);
                    MessageBox.Show("Registro Borrado", "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Registro relacionado...\nBaja denegada",
                        "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }

        private void NuevoMetroButton_Click(object sender, EventArgs e)
        {
            AutorAEForm frm = new AutorAEForm();
            frm.Text = "Nuevo Autor";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                try
                {
                   Autor autor = frm.GetAutor();
                    if (!servicio.Existe(autor))
                    {
                        servicio.Agregar(autor);
                        var r = ConstruirFila();
                        SetearFila(r, autor);
                        MessageBox.Show("Registro Agregado", "Mensaje",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Registro Duplicado... Alta denegada", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                catch (Exception exception)
                {

                    MessageBox.Show(exception.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void EditarMetroButton_Click(object sender, EventArgs e)
        {
            if (AutorMetroGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow r = AutorMetroGrid.SelectedRows[0];
                Autor autor = (Autor)r.Tag;
                AutorAEForm frm = new AutorAEForm();
                frm.Text = "Editar Autor";
                frm.SetAutor(autor);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        autor = frm.GetAutor();
                        if (!servicio.Existe(autor))
                        {
                            servicio.Editar(autor);
                            SetearFila(r, autor);
                            MessageBox.Show("Registro editado", "Mensaje", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }

                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}

