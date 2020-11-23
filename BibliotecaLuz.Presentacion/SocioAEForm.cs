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
    public partial class SocioAEForm : MetroFramework.Forms.MetroForm
    {
        public SocioAEForm()
        {
            InitializeComponent();
        }

        private Socio socio;
        private SocioEditDto socioDto;


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //cargo combo provincias
            ServicioProvincias servicioProvincias = new ServicioProvincias();
            var listaProvincia = servicioProvincias.GetProvincias();
            var defaultProvincia = new Provincia
            {
                ProvinciaId = 0,
                NombreProvincia = "<Seleccione Provincia>"

            };

            listaProvincia.Insert(0, defaultProvincia);

            ProvinciaMetroComboBox.DataSource = listaProvincia;
            ProvinciaMetroComboBox.DisplayMember = "NombreProvincia";
            ProvinciaMetroComboBox.ValueMember = "ProvinciaId";
            ProvinciaMetroComboBox.SelectedIndex = 0;
            // cargo combo localidades

            ServicioLocalidades servicioLocalidades = new ServicioLocalidades();
            var listaLocalidades = servicioLocalidades.GetLocalidad();
            var defaultLocalidad = new Localidad
            {
                LocalidadId = 0,
                NombreLocalidad = "<Seleccione Localidad>"
            };

            listaLocalidades.Insert(0, defaultLocalidad);

            LocalidadesMetroComboBox.DataSource = listaLocalidades;
            LocalidadesMetroComboBox.DisplayMember = "NombreLocalidad";
            LocalidadesMetroComboBox.ValueMember = "LocalidadId";
            LocalidadesMetroComboBox.SelectedIndex = 0;

            if (socio != null)
            {
                LocalidadesMetroComboBox.SelectedValue = socio.Localidad.LocalidadId;
                ProvinciaMetroComboBox.SelectedValue = socio.Provincia.ProvinciaId;
            }
        }

        private void CancelMetroButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

      
       
        private void OkMetroButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (socioDto == null)
                {
                    socioDto = new SocioEditDto();
                }
                socioDto.Nombre = NombreMetroTextBox.Text;
                socioDto.Apellido = ApellidoMetroTextBox.Text;
                socioDto.Direccion = DireccionMetroTextBox.Text;
                socioDto.LocalidadListDto = Mapeador.ConvertirLocalidadListDto((Localidad)LocalidadesMetroComboBox.SelectedItem);
                socioDto.ProvinciaListDto = Mapeador.ConvertirProvinciaListDto((Provincia)ProvinciaMetroComboBox.SelectedItem);
                socioDto.TelefonoFijo = TelefonoFijoMetroTextBox.Text;
                socioDto.TelefonoMovil = TelefonoMovilMetroTextBox.Text;
                socioDto.CorreoElectronico = CorreoMetroTextBox.Text;
                
                DialogResult = DialogResult.OK;

            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(NombreMetroTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(NombreMetroTextBox, "Ingrese un Nombre");
            }
            if (string.IsNullOrEmpty(ApellidoMetroTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(ApellidoMetroTextBox, "Ingrese un Apellido");
            }

            if (string.IsNullOrEmpty(DireccionMetroTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(DireccionMetroTextBox, "Ingrese un Apellido");
            }

            if (LocalidadesMetroComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(LocalidadesMetroComboBox, "Debe seleccionar una Localidad");
            }
            if (ProvinciaMetroComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(ProvinciaMetroComboBox, "Debe seleccionar una Provincia");
            }
            return valido;
        }

        internal SocioEditDto GetSocio()
        {
            return socioDto;
        }
    }
}
