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
    public partial class ProvinciasAEForm : MetroFramework.Forms.MetroForm
    {
        public ProvinciasAEForm()
        {
            InitializeComponent();
        }
        

        private void ProvinciasAEForm_Load(object sender, EventArgs e)
        {
           


        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (provincia!= null)
            {
                ProvinciaMetroTextBox.Text = provincia.NombreProvincia;
            }
        }
        private Provincia provincia;
        private void OkMetroButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (provincia == null)
                {
                    provincia = new Provincia();
                }

                provincia.NombreProvincia = ProvinciaMetroTextBox.Text.Trim();
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            if (string.IsNullOrEmpty(ProvinciaMetroTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(ProvinciaMetroTextBox, "Debe ingresar una provincia");
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
            this.provincia = provincia;
        }
    }
}
