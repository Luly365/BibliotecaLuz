using BibliotecaLuz.Entidades.DTOs.Socio;
using BibliotecaLuz.Entidades.Entities;
using BibliotecaLuz.Entidades.Mapas;
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
    public partial class SociosForm : MetroFramework.Forms.MetroForm

    {
        public SociosForm()
        {
            InitializeComponent();
        }

        private ServicioSocios _servicio;
        private List<SocioListDto> _lista;

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void localidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocalidadesForm frm = new LocalidadesForm();
            frm.ShowDialog(this);
        }

        private void SalirMetroButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void provinciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProvinciasForm frm = new ProvinciasForm();
            frm.ShowDialog(this);
        }

        private void tipoDeDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoDeDocForm frm = new TipoDeDocForm();
            frm.ShowDialog(this);
        }

        private void SociosForm_Load(object sender, EventArgs e)
        {

            _servicio = new ServicioSocios();
            try
            {
                _lista = _servicio.GetLista();
                MostrarDatosEnGrilla();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        private void MostrarDatosEnGrilla()
        {
            SociosMetroGrid.Rows.Clear();

            foreach (var socioListDto in _lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, socioListDto);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            SociosMetroGrid.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, SocioListDto socioListDto)
        {
            r.Cells[cmnNombre.Index].Value = socioListDto.Nombre;
            r.Cells[cmnApellido.Index].Value = socioListDto.Apellido;
            r.Cells[cmnDireccion.Index].Value = socioListDto.Direccion;
            r.Cells[cmnLocalidad.Index].Value = socioListDto.LocalidadListDto.NombreLocalidad;
            r.Cells[cmnTelFijo.Index].Value = socioListDto.TelefonoFijo;
            r.Cells[cmnCel.Index].Value = socioListDto.TelefonoMovil;
            r.Cells[cmnCorreo.Index].Value = socioListDto.CorreoElectronico;
            r.Cells[cmnSancionado.Index].Value = socioListDto.Sancionado;
            r.Cells[cmnActivo.Index].Value = socioListDto.Activo;
            r.Tag = socioListDto;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(SociosMetroGrid);
            return r;

        }

        private void NuevoMetroButton_Click(object sender, EventArgs e)
        {
            SocioAEForm frm = new SocioAEForm(); 
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                try
                {
                    SocioEditDto socioEditDto = frm.GetSocio();
                    _servicio.Agregar(socioEditDto);
                    DataGridViewRow r = ConstruirFila();
                    SocioListDto socioListDto= Mapeador.ConvertirASocioDto(socioEditDto);
                    SetearFila(r,socioListDto);
                    AgregarFila(r);

                    MessageBox.Show("Registro Agregado", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                    
                }
            }
        }
    }
}
