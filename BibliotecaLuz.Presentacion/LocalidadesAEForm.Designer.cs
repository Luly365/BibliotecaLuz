namespace BibliotecaLuz.Presentacion
{
    partial class LocalidadesAEForm
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
            this.LocalidadMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.CancelMetroButton = new MetroFramework.Controls.MetroButton();
            this.OkMetroButton = new MetroFramework.Controls.MetroButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ProvinciasMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.ProvinciasMetroComboBox = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(49, 68);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(72, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Localidad :";
            // 
            // LocalidadMetroTextBox
            // 
            // 
            // 
            // 
            this.LocalidadMetroTextBox.CustomButton.Image = null;
            this.LocalidadMetroTextBox.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.LocalidadMetroTextBox.CustomButton.Name = "";
            this.LocalidadMetroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.LocalidadMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.LocalidadMetroTextBox.CustomButton.TabIndex = 1;
            this.LocalidadMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LocalidadMetroTextBox.CustomButton.UseSelectable = true;
            this.LocalidadMetroTextBox.CustomButton.Visible = false;
            this.LocalidadMetroTextBox.Lines = new string[0];
            this.LocalidadMetroTextBox.Location = new System.Drawing.Point(127, 68);
            this.LocalidadMetroTextBox.MaxLength = 32767;
            this.LocalidadMetroTextBox.Name = "LocalidadMetroTextBox";
            this.LocalidadMetroTextBox.PasswordChar = '\0';
            this.LocalidadMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LocalidadMetroTextBox.SelectedText = "";
            this.LocalidadMetroTextBox.SelectionLength = 0;
            this.LocalidadMetroTextBox.SelectionStart = 0;
            this.LocalidadMetroTextBox.ShortcutsEnabled = true;
            this.LocalidadMetroTextBox.Size = new System.Drawing.Size(198, 23);
            this.LocalidadMetroTextBox.TabIndex = 1;
            this.LocalidadMetroTextBox.UseSelectable = true;
            this.LocalidadMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.LocalidadMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CancelMetroButton
            // 
            this.CancelMetroButton.BackgroundImage = global::BibliotecaLuz.Presentacion.Properties.Resources.borrar_48px;
            this.CancelMetroButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelMetroButton.Location = new System.Drawing.Point(250, 205);
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
            this.OkMetroButton.Location = new System.Drawing.Point(46, 205);
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
            // ProvinciasMetroLabel
            // 
            this.ProvinciasMetroLabel.AutoSize = true;
            this.ProvinciasMetroLabel.Location = new System.Drawing.Point(49, 136);
            this.ProvinciasMetroLabel.Name = "ProvinciasMetroLabel";
            this.ProvinciasMetroLabel.Size = new System.Drawing.Size(70, 19);
            this.ProvinciasMetroLabel.TabIndex = 4;
            this.ProvinciasMetroLabel.Text = "Provincias:";
            // 
            // ProvinciasMetroComboBox
            // 
            this.ProvinciasMetroComboBox.FormattingEnabled = true;
            this.ProvinciasMetroComboBox.ItemHeight = 23;
            this.ProvinciasMetroComboBox.Location = new System.Drawing.Point(126, 133);
            this.ProvinciasMetroComboBox.Name = "ProvinciasMetroComboBox";
            this.ProvinciasMetroComboBox.Size = new System.Drawing.Size(199, 29);
            this.ProvinciasMetroComboBox.TabIndex = 5;
            this.ProvinciasMetroComboBox.UseSelectable = true;
            // 
            // LocalidadesAEForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 291);
            this.Controls.Add(this.ProvinciasMetroComboBox);
            this.Controls.Add(this.ProvinciasMetroLabel);
            this.Controls.Add(this.CancelMetroButton);
            this.Controls.Add(this.OkMetroButton);
            this.Controls.Add(this.LocalidadMetroTextBox);
            this.Controls.Add(this.metroLabel1);
            this.Name = "LocalidadesAEForm";
            this.Text = "Agregar Localidad";
            this.Load += new System.EventHandler(this.ProvinciasAEForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox LocalidadMetroTextBox;
        private MetroFramework.Controls.MetroButton OkMetroButton;
        private MetroFramework.Controls.MetroButton CancelMetroButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MetroFramework.Controls.MetroComboBox ProvinciasMetroComboBox;
        private MetroFramework.Controls.MetroLabel ProvinciasMetroLabel;
    }
}