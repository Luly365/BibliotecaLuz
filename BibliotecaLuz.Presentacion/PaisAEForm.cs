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
    public partial class PaisAEForm : MetroFramework.Forms.MetroForm
    {
        public PaisAEForm()
        {
            InitializeComponent();
        }
        

        private void PaisAEForm_Load(object sender, EventArgs e)
        {
           


        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (pais!= null)
            {
                PaisMetroTextBox.Text = pais.NombrePais;
            }
        }
        private Pais pais;
        private void OkMetroButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (pais == null)
                {
                    pais = new Pais();
                }

                pais.NombrePais = PaisMetroTextBox.Text.Trim();
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            if (string.IsNullOrEmpty(PaisMetroTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(PaisMetroTextBox, "Debe ingresar una provincia");
            }

            return valido;
        }

        public Pais GetPais()
        {
            return pais;
        }

        private void CancelMetroButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public void SetPais(Pais pais)
        {
            this.pais = pais;
        }
    }
}
