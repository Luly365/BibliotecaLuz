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
    public partial class TipoDeDocForm : MetroFramework.Forms.MetroForm

    {
        public TipoDeDocForm()
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
        private ServicioTipoDeDocumentos servicio;
        List<TipoDeDocumento> lista;
        private void LocalidadesForm_Load(object sender, EventArgs e)
        {
            servicio = new ServicioTipoDeDocumentos();
            lista = servicio.GetTipoDeDoc();
            MostraDatosEnGrilla();

        }

        private void MostraDatosEnGrilla()
        {
            TipoDeDocMetroGrid.Rows.Clear();
            foreach (var tipodedoc in lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, tipodedoc);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            TipoDeDocMetroGrid.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, TipoDeDocumento tipoDeDocumento)
        {
            r.Cells[cmnTipoDeDoc.Index].Value = tipoDeDocumento.Descripcion;
            r.Tag = tipoDeDocumento;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(TipoDeDocMetroGrid);
            return r;
        }
        //borrar//
        private void BorrarMetroButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = TipoDeDocMetroGrid.SelectedRows[0];
            TipoDeDocumento tipoDeDocumento = (TipoDeDocumento)r.Tag;
            DialogResult dr = MetroMessageBox.Show(this, $"Desea dar de baja el {tipoDeDocumento.Descripcion}",
                "Confirmar baja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    servicio.Borrar(tipoDeDocumento.TipoDeDocId);
                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message);
                }
            }


        }

        private void NuevoMetroButton_Click(object sender, EventArgs e)
        {
            TipoDeDocAEForm frm = new TipoDeDocAEForm();
            frm.Text = "Agregar Tipos de Documentos";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                try
                {
                    TipoDeDocumento tipoDeDocumento = frm.GetTipoDeDoc();
                    if (!servicio.Existe(tipoDeDocumento))
                    {
                        servicio.Agregar(tipoDeDocumento);
                        var r = ConstruirFila();
                        SetearFila(r, tipoDeDocumento);
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

        private void EditarMetroButton_Click(object sender, EventArgs e)
        {
            if (TipoDeDocMetroGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow r = TipoDeDocMetroGrid.SelectedRows[0];
                TipoDeDocumento tipoDeDocumento = (TipoDeDocumento)r.Tag;
                TipoDeDocAEForm frm = new TipoDeDocAEForm();
                frm.Text = "Editar Tipo De Documento";
                frm.SetTipoDeDoc(tipoDeDocumento);//
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        tipoDeDocumento = frm.GetTipoDeDoc();
                        if (!servicio.Existe(tipoDeDocumento))
                        {
                            servicio.Editar(tipoDeDocumento);
                            SetearFila(r, tipoDeDocumento);
                            MessageBox.Show("Registro Editado", "Mensaje", MessageBoxButtons.OK,
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

