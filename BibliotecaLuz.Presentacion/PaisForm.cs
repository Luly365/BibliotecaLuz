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
    public partial class PaisForm : MetroFramework.Forms.MetroForm

    {
        public PaisForm()
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
        private ServicioPais servicio;
        List<Pais> lista;
        private void PaisForm_Load_1(object sender, EventArgs e)
        {
            try
            {
                servicio = new ServicioPais();
                lista = servicio.GetPais();
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
            PaisMetroGrid.Rows.Clear();
            foreach (var pais in lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, pais);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            PaisMetroGrid.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Pais pais)
        {
            r.Cells[cmnPais.Index].Value = pais.NombrePais;
            r.Tag = pais;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(PaisMetroGrid);
            return r;
        }
        //borrar//
        private void BorrarMetroButton_Click(object sender, EventArgs e)
        {
            if (PaisMetroGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow r = PaisMetroGrid.SelectedRows[0];
                Pais pais = (Pais)r.Tag;
                DialogResult dr = MessageBox.Show($"¿Desea dar de baja al Pais {pais.NombrePais}?",
                    "Confirmar Baja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    servicio.Borrar(pais.PaisId);
                    PaisMetroGrid.Rows.Remove(r);
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
            PaisAEForm frm = new PaisAEForm();
            frm.Text = "Nuevo Pais";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                try
                {
                    Pais pais = frm.GetPais();
                    if (!servicio.Existe(pais))
                    {
                        servicio.Agregar(pais);
                        var r = ConstruirFila();
                        SetearFila(r, pais);
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
            if (PaisMetroGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow r = PaisMetroGrid.SelectedRows[0];
                Pais pais = (Pais)r.Tag;
                PaisAEForm frm = new PaisAEForm();
                frm.Text = "Editar Pais";
                frm.SetPais(pais);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        pais = frm.GetPais();
                        if (!servicio.Existe(pais))
                        {
                            servicio.Editar(pais);
                            SetearFila(r, pais);
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

