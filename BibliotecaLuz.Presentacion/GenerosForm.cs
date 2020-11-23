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
    public partial class GenerosForm : MetroFramework.Forms.MetroForm

    {
        public GenerosForm()
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
        private ServicioGenero servicio;
        List<Genero> lista;
        private void GeneroForm_Load(object sender, EventArgs e)
        {
            try
            {
                servicio = new ServicioGenero();
                lista = servicio.GetGeneros();
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
            GenerosMetroGrid.Rows.Clear();
            foreach (var genero in lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, genero);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            GenerosMetroGrid.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Genero genero)
        {
            r.Cells[cmnGenero.Index].Value = genero.Descripcion;
            

            r.Tag = genero;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(GenerosMetroGrid);
            return r;
        }
        //borrar//
        private void BorrarMetroButton_Click(object sender, EventArgs e)
        {
            if (GenerosMetroGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow r = GenerosMetroGrid.SelectedRows[0];
                Genero genero = (Genero)r.Tag;
                DialogResult dr = MessageBox.Show($"¿Desea dar de baja al Genero {genero.Descripcion}?",
                    "Confirmar Baja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    servicio.Borrar(genero.generoId);
                    GenerosMetroGrid.Rows.Remove(r);
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
            GenerosAEForm frm = new GenerosAEForm();
            frm.Text = "Nuevo Genero";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                try
                {
                    Genero genero = frm.GetGenero();
                    if (!servicio.Existe(genero))
                    {
                        servicio.Agregar(genero);
                        var r = ConstruirFila();
                        SetearFila(r, genero);
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
            if (GenerosMetroGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow r = GenerosMetroGrid.SelectedRows[0];
                Genero genero = (Genero)r.Tag;
                GenerosAEForm frm = new GenerosAEForm();
                frm.Text = "Editar Genero";
                frm.SetGenero(genero);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        genero = frm.GetGenero();
                        if (!servicio.Existe(genero))
                        {
                            servicio.Editar(genero);
                            SetearFila(r, genero);
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

