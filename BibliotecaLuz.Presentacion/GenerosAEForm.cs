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
    public partial class GenerosAEForm : MetroFramework.Forms.MetroForm
    {
        public GenerosAEForm()
        {
            InitializeComponent();
        }
        

        private void GenerosAEForm_Load(object sender, EventArgs e)
        {
           


        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (genero!= null)
            {
                GeneroMetroTextBox.Text = genero.Descripcion;
            }
        }
        private Genero genero;
        private void OkMetroButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (genero == null)
                {
                    genero = new Genero();
                }

                genero.Descripcion = GeneroMetroTextBox.Text.Trim();
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            if (string.IsNullOrEmpty(GeneroMetroTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(GeneroMetroTextBox, "Debe ingresar un Genero");
            }

            return valido;
        }

     

        private void CancelMetroButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public void SetGenero(Genero g)
        {
            this.genero = genero;
        }

        public Genero GetGenero()
        {
            return genero;
        }

       
    }
}
