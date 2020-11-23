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
    public partial class TipoDeDocAEForm : MetroFramework.Forms.MetroForm
    {
        public TipoDeDocAEForm()
        {
            InitializeComponent();
        }
        

        private void ProvinciasAEForm_Load(object sender, EventArgs e)
        {
           


        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (tipoDeDocumento!= null)
            {
                TipoDeDocMetroTextBox.Text = tipoDeDocumento.Descripcion;
            }
        }
        private TipoDeDocumento tipoDeDocumento;
        private void OkMetroButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (tipoDeDocumento == null)
                {
                    tipoDeDocumento = new TipoDeDocumento();
                }

                tipoDeDocumento.Descripcion = TipoDeDocMetroTextBox.Text.Trim();
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            if (string.IsNullOrEmpty(TipoDeDocMetroTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(TipoDeDocMetroTextBox, "Debe ingresar un tipo de documento");
            }

            return valido;
        }

        

        private void CancelMetroButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

       

        public TipoDeDocumento GetTipoDeDoc()
        {
            return tipoDeDocumento;
        }

       public  void SetTipoDeDoc(TipoDeDocumento tipoDeDocumento)
        {
            this.tipoDeDocumento = tipoDeDocumento;
        }
    }
}
