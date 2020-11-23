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
    public partial class LocalidadesForm : MetroFramework.Forms.MetroForm
        
    {
        public LocalidadesForm()
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
        private ServicioLocalidades servicio;
        List<Localidad> lista;
        private void LocalidadesForm_Load(object sender, EventArgs e)
        {
            try
            {
                servicio = new ServicioLocalidades();
                lista = servicio.GetLocalidad();
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
            LocalidadesMetroGrid.Rows.Clear();
            foreach (var localidad in lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, localidad);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            LocalidadesMetroGrid.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Localidad localidad)
        {
            r.Cells[cmnLocalidad.Index].Value = localidad.NombreLocalidad;
            r.Cells[cmnProvincia.Index].Value = localidad.provincia.NombreProvincia;
            r.Tag = localidad;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(LocalidadesMetroGrid);
            return r;
        }
        //borrar//
        private void BorrarMetroButton_Click(object sender, EventArgs e)
        {
            if (LocalidadesMetroGrid.SelectedRows.Count>0)
            {
                DataGridViewRow r = LocalidadesMetroGrid.SelectedRows[0];
                Localidad localidad = (Localidad)r.Tag;
                DialogResult dr = MessageBox.Show($"¿Desea dar de baja a la provincia {localidad.NombreLocalidad}?",
                    "Confirmar Baja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        if (!servicio.EstaRelacionado(localidad))
                        {
                            servicio.Borrar(localidad);
                            LocalidadesMetroGrid.Rows.Remove(r);
                            MessageBox.Show("Registro Borrado", "Mensaje",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        else
                        {
                            MessageBox.Show("Localidad con Provincias relacionadas \nBaja Rechazada", "Error!!",
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
            LocalidadesAEForm frm = new LocalidadesAEForm();
            frm.Text = "Nueva Localidad";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                try
                {
                    Localidad localidad = frm.GetLocalidad();

                    if (!servicio.Existe(localidad))
                    {
                        servicio.Agregar(localidad);
                        DataGridViewRow r = ConstruirFila();
                        SetearFila(r, localidad);
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
            if (LocalidadesMetroGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow r = LocalidadesMetroGrid.SelectedRows[0];
                Localidad localidad = (Localidad)r.Tag;
               Localidad localidadAux = (Localidad)localidad.Clone();
                LocalidadesAEForm frm = new LocalidadesAEForm();
                frm.Text = "Editar Intérprete";
                frm.SetLocalidad(localidad);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        localidad = frm.GetLocalidad();

                        if (!servicio.Existe(localidad))
                        {
                            servicio.Editar(localidad);
                            SetearFila(r,localidad);
                            MessageBox.Show("Registro Editado", "Mensaje",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            SetearFila(r, localidadAux);

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
