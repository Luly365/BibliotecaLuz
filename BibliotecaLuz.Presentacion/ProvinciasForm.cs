using BibliotecaLuz.Entidades.Entities;
using BibliotecaLuz.Servicios;
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
    public partial class ProvinciasForm : MetroFramework.Forms.MetroForm
        
    {
        public ProvinciasForm()
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
        private ServicioProvincias servicio;
        List<Provincia> lista;
        private void ProvinciasForm_Load(object sender, EventArgs e)
        {
            servicio = new ServicioProvincias();
            lista = servicio.GetProvincias();
            MostraDatosEnGrilla();
        }

        private void MostraDatosEnGrilla()
        {
            ProvinciaMetroGrid.Rows.Clear();
            foreach (var localidad in lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, localidad);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            ProvinciaMetroGrid.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Provincia provincia)
        {
            r.Cells[cmnProvincia.Index].Value = provincia.NombreProvincia;
            r.Tag = provincia;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(ProvinciaMetroGrid);
            return r;
        }

        private void NuevoMetroButton_Click(object sender, EventArgs e)
        {
            ProvinciasAEForm frm = new ProvinciasAEForm();
            frm.Text = "Agregar Provincias";
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.OK)
            {
                try
                {
                    Provincia provincia = frm.GetProvincia();
                    if (!servicio.Existe(provincia))
                    {
                        servicio.Agregar(provincia);
                        var r = ConstruirFila();
                        SetearFila(r, provincia);
                        MessageBox.Show("Registro agregado", "Mensaje",
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

        private void BorrarMetroButton_Click(object sender, EventArgs e)
        {
            if (ProvinciaMetroGrid.SelectedRows.Count > 0)
            {
                var r = ProvinciaMetroGrid.SelectedRows[0];
                Provincia provincia = (Provincia)r.Tag;

                DialogResult dr = MessageBox.Show($"¿Desea borrar de la lista a {provincia.NombreProvincia}?",
                    "Confirmar Baja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    servicio.Borrar(provincia.ProvinciaId);
                    ProvinciaMetroGrid.Rows.Remove(r);
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

        private void EditarMetroButton_Click(object sender, EventArgs e)
        {
            if (ProvinciaMetroGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow r = ProvinciaMetroGrid.SelectedRows[0];
                Provincia p = (Provincia)r.Tag;
                ProvinciasAEForm frm = new ProvinciasAEForm();
                frm.Text = "Editar Provincia";
                frm.SetProvincia(p);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        p = frm.GetProvincia();
                        if (!servicio.Existe(p))
                        {
                            servicio.Editar(p);
                            SetearFila(r, p);
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
