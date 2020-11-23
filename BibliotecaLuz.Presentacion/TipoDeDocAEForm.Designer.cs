namespace BibliotecaLuz.Presentacion
{
    partial class TipoDeDocAEForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TipoDeDocMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.CancelMetroButton = new MetroFramework.Controls.MetroButton();
            this.OkMetroButton = new MetroFramework.Controls.MetroButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 95);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(140, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Tipos De Documentos:";
            // 
            // TipoDeDocMetroTextBox
            // 
            // 
            // 
            // 
            this.TipoDeDocMetroTextBox.CustomButton.Image = null;
            this.TipoDeDocMetroTextBox.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.TipoDeDocMetroTextBox.CustomButton.Name = "";
            this.TipoDeDocMetroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TipoDeDocMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TipoDeDocMetroTextBox.CustomButton.TabIndex = 1;
            this.TipoDeDocMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TipoDeDocMetroTextBox.CustomButton.UseSelectable = true;
            this.TipoDeDocMetroTextBox.CustomButton.Visible = false;
            this.TipoDeDocMetroTextBox.Lines = new string[0];
            this.TipoDeDocMetroTextBox.Location = new System.Drawing.Point(169, 95);
            this.TipoDeDocMetroTextBox.MaxLength = 32767;
            this.TipoDeDocMetroTextBox.Name = "TipoDeDocMetroTextBox";
            this.TipoDeDocMetroTextBox.PasswordChar = '\0';
            this.TipoDeDocMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TipoDeDocMetroTextBox.SelectedText = "";
            this.TipoDeDocMetroTextBox.SelectionLength = 0;
            this.TipoDeDocMetroTextBox.SelectionStart = 0;
            this.TipoDeDocMetroTextBox.ShortcutsEnabled = true;
            this.TipoDeDocMetroTextBox.Size = new System.Drawing.Size(198, 23);
            this.TipoDeDocMetroTextBox.TabIndex = 1;
            this.TipoDeDocMetroTextBox.UseSelectable = true;
            this.TipoDeDocMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TipoDeDocMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CancelMetroButton
            // 
            this.CancelMetroButton.BackgroundImage = global::BibliotecaLuz.Presentacion.Properties.Resources.borrar_48px;
            this.CancelMetroButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelMetroButton.Location = new System.Drawing.Point(292, 144);
            this.CancelMetroButton.Name = "CancelMetroButton";
            this.CancelMetroButton.Size = new System.Drawing.Size(75, 63);
            this.CancelMetroButton.TabIndex = 3;
            this.CancelMetroButton.UseSelectable = true;
            this.CancelMetroButton.Click += new System.EventHandler(this.CancelMetroButton_Click);
            // 
            // OkMetroButton
            // 
            this.OkMetroButton.BackgroundImage = global::BibliotecaLuz.Presentacion.Properties.Resources.ok_48px;
            this.OkMetroButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.OkMetroButton.Location = new System.Drawing.Point(23, 144);
            this.OkMetroButton.Name = "OkMetroButton";
            this.OkMetroButton.Size = new System.Drawing.Size(75, 63);
            this.OkMetroButton.TabIndex = 2;
            this.OkMetroButton.UseSelectable = true;
            this.OkMetroButton.Click += new System.EventHandler(this.OkMetroButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TipoDeDocAEForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 243);
            this.Controls.Add(this.CancelMetroButton);
            this.Controls.Add(this.OkMetroButton);
            this.Controls.Add(this.TipoDeDocMetroTextBox);
            this.Controls.Add(this.metroLabel1);
            this.Name = "TipoDeDocAEForm";
            this.Text = "Agregar Tipos de Documentos";
            this.Load += new System.EventHandler(this.ProvinciasAEForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox TipoDeDocMetroTextBox;
        private MetroFramework.Controls.MetroButton OkMetroButton;
        private MetroFramework.Controls.MetroButton CancelMetroButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}