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
    public partial class EditorialesForm : MetroFramework.Forms.MetroForm
        
    {
        public EditorialesForm()
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
        private ServicioEditoriales servicio;
        List<Editorial> lista;
        private void EditorialesForm_Load(object sender, EventArgs e)
        {
            try
            {
                servicio = new ServicioEditoriales();
                lista = servicio.GetEditorial();
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
            EditorialesMetroGrid.Rows.Clear();
            foreach (var editorial in lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, editorial);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            EditorialesMetroGrid.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Editorial editorial)
        {
            r.Cells[cmnEditorial.Index].Value = editorial.NombreEditorial;
            r.Cells[cmnPais.Index].Value = editorial.Pais.NombrePais;
            r.Tag = editorial;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(EditorialesMetroGrid);
            return r;
        }
        //borrar//
        private void BorrarMetroButton_Click(object sender, EventArgs e)
        {
            if (EditorialesMetroGrid.SelectedRows.Count>0)
            {
                DataGridViewRow r = EditorialesMetroGrid.SelectedRows[0];
                Editorial editorial = (Editorial)r.Tag;
                DialogResult dr = MessageBox.Show($"¿Desea dar de baja a la Editorial {editorial.NombreEditorial}?",
                    "Confirmar Baja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        if (!servicio.EstaRelaciona(editorial))
                        {
                            servicio.Borrar(editorial);
                            EditorialesMetroGrid.Rows.Remove(r);
                            MessageBox.Show("Registro Borrado", "Mensaje",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        else
                        {
                            MessageBox.Show("Editorial con Paises relacionados \nBaja Rechazada", "Error!!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, "¡¡Error!!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }
                }
            }
        }

        private void NuevoMetroButton_Click(object sender, EventArgs e)
        {
            EditorialesAEForm frm = new EditorialesAEForm();
            frm.Text = "Nueva Editorial";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                try
                {
                    Editorial editorial  = frm.GetEditorial();

                    if (!servicio.Existe(editorial))
                    {
                        servicio.Agregar(editorial);
                        DataGridViewRow r = ConstruirFila();
                        SetearFila(r, editorial);
                        AgregarFila(r);
                        MessageBox.Show("Registro Agregado", "Mensaje",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Registro Duplicado \nAlta Denegada", "Error",
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
            if (EditorialesMetroGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow r = EditorialesMetroGrid.SelectedRows[0];
                Editorial editorial = (Editorial)r.Tag;
               Editorial editorialAux = (Editorial)editorial.Clone();
                EditorialesAEForm frm = new EditorialesAEForm();
                frm.Text = "Editar Editorial";
                frm.SetEditorial(editorial);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        editorial = frm.GetEditorial();

                        if (!servicio.Existe(editorial))
                        {
                            servicio.Editar(editorial);
                            SetearFila(r, editorial);
                            MessageBox.Show("Registro Editado", "Mensaje",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            SetearFila(r, editorialAux);

                            MessageBox.Show("Registro Duplicado \nAlta Denegada", "Error",
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
        }

       
    }
}
