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
    public partial class LocalidadesAEForm : MetroFramework.Forms.MetroForm
    {
        private Localidad localidad;
        public LocalidadesAEForm()
        {
            InitializeComponent();
        }
        

        private void ProvinciasAEForm_Load(object sender, EventArgs e)
        {
           


        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ServicioProvincias servicioProvincias = new ServicioProvincias();
            var listaProvincia = servicioProvincias.GetProvincias();
            var defaultProvincia = new Provincia
            {
                ProvinciaId = 0,
                NombreProvincia = "<Seleccione Provincia>"

            };

            listaProvincia.Insert(0, defaultProvincia);
            ProvinciasMetroComboBox.DataSource = listaProvincia;
            ProvinciasMetroComboBox.DisplayMember = "NombreProvincia";
            ProvinciasMetroComboBox.ValueMember = "ProvinciaId";
            ProvinciasMetroComboBox.SelectedIndex = 0;


            if (localidad!= null)
            {
                LocalidadMetroTextBox.Text = localidad.NombreLocalidad;
                ProvinciasMetroComboBox.SelectedValue = localidad.provincia.ProvinciaId;
            }
        }
        private Provincia provincia;
        private void OkMetroButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (localidad == null)
                {
                    localidad = new Localidad();
                }

                localidad.NombreLocalidad = LocalidadMetroTextBox.Text.Trim();
                localidad.provincia = (Provincia)ProvinciasMetroComboBox.SelectedItem;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(LocalidadMetroTextBox.Text) && string.IsNullOrWhiteSpace(LocalidadMetroTextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(LocalidadMetroTextBox, "El nombre del intérprete es requerido");
            }

            if (ProvinciasMetroComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(ProvinciasMetroComboBox, "Debe seleccionar una Provincia");

            }

            return valido;
        }

        public Provincia GetProvincia()
        {
            return provincia;
        }

        private void CancelMetroButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public void SetProvincia(Provincia p)
        {
            this.provincia = provincia;//en provincia que esta de la derecha es una (p) sola.
        }

        public Localidad GetLocalidad()
        {
            return localidad;
        }

        public void SetLocalidad(Localidad localidad)
        {
            this.localidad = localidad;
        }
    }
}
