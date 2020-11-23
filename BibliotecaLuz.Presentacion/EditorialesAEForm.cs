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
    public partial class EditorialesAEForm : MetroFramework.Forms.MetroForm
    {
        private Editorial editorial;
        public EditorialesAEForm()
        {
            InitializeComponent();
        }
        

        private void EditorialesAEForm_Load(object sender, EventArgs e)
        {
           


        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ServicioPais servicioPais = new ServicioPais();
            var listaPais = servicioPais.GetPais();
            var defaultPais = new Pais
            {
                PaisId = 0,
                NombrePais = "<Seleccione Pais>"

            };

            listaPais.Insert(0, defaultPais);
            PaisMetroComboBox.DataSource = listaPais;
            PaisMetroComboBox.DisplayMember = "NombrePais";
            PaisMetroComboBox.ValueMember = "PaisId";
            PaisMetroComboBox.SelectedIndex = 0;


            if (editorial!= null)
            {
                EditorialMetroTextBox.Text = editorial.NombreEditorial;
                PaisMetroComboBox.SelectedValue = editorial.Pais.PaisId;
            }
        }
        private Pais pais;
        private void OkMetroButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (editorial == null)
                {
                    editorial = new Editorial();
                }

                editorial.NombreEditorial = EditorialMetroTextBox.Text.Trim();
                editorial.Pais = (Pais)PaisMetroComboBox.SelectedItem;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(EditorialMetroTextBox.Text) && string.IsNullOrWhiteSpace(EditorialMetroTextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(EditorialMetroTextBox, "El nombre de la Editorial es requerido");
            }

            if (PaisMetroComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(PaisMetroComboBox, "Debe seleccionar un Pais");

            }

            return valido;
        }

        public Editorial GetEditorial()
        {
            return editorial;
        }

        private void CancelMetroButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public void SetEditorial(Editorial p)
        {
            this.editorial = editorial;//en provincia que esta de la derecha es una (p) sola.
        }

        
    }
}
