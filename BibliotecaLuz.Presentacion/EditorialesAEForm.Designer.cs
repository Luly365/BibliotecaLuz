namespace BibliotecaLuz.Presentacion
{
    partial class EditorialesAEForm
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
            this.EditorialMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.CancelMetroButton = new MetroFramework.Controls.MetroButton();
            this.OkMetroButton = new MetroFramework.Controls.MetroButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ProvinciasMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.PaisMetroComboBox = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(49, 68);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(60, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Editorial:";
            // 
            // EditorialMetroTextBox
            // 
            // 
            // 
            // 
            this.EditorialMetroTextBox.CustomButton.Image = null;
            this.EditorialMetroTextBox.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.EditorialMetroTextBox.CustomButton.Name = "";
            this.EditorialMetroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.EditorialMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.EditorialMetroTextBox.CustomButton.TabIndex = 1;
            this.EditorialMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.EditorialMetroTextBox.CustomButton.UseSelectable = true;
            this.EditorialMetroTextBox.CustomButton.Visible = false;
            this.EditorialMetroTextBox.Lines = new string[0];
            this.EditorialMetroTextBox.Location = new System.Drawing.Point(127, 68);
            this.EditorialMetroTextBox.MaxLength = 32767;
            this.EditorialMetroTextBox.Name = "EditorialMetroTextBox";
            this.EditorialMetroTextBox.PasswordChar = '\0';
            this.EditorialMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.EditorialMetroTextBox.SelectedText = "";
            this.EditorialMetroTextBox.SelectionLength = 0;
            this.EditorialMetroTextBox.SelectionStart = 0;
            this.EditorialMetroTextBox.ShortcutsEnabled = true;
            this.EditorialMetroTextBox.Size = new System.Drawing.Size(198, 23);
            this.EditorialMetroTextBox.TabIndex = 1;
            this.EditorialMetroTextBox.UseSelectable = true;
            this.EditorialMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.EditorialMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.ProvinciasMetroLabel.Location = new System.Drawing.Point(75, 143);
            this.ProvinciasMetroLabel.Name = "ProvinciasMetroLabel";
            this.ProvinciasMetroLabel.Size = new System.Drawing.Size(34, 19);
            this.ProvinciasMetroLabel.TabIndex = 4;
            this.ProvinciasMetroLabel.Text = "Pais:";
            // 
            // PaisMetroComboBox
            // 
            this.PaisMetroComboBox.FormattingEnabled = true;
            this.PaisMetroComboBox.ItemHeight = 23;
            this.PaisMetroComboBox.Location = new System.Drawing.Point(126, 133);
            this.PaisMetroComboBox.Name = "PaisMetroComboBox";
            this.PaisMetroComboBox.Size = new System.Drawing.Size(199, 29);
            this.PaisMetroComboBox.TabIndex = 5;
            this.PaisMetroComboBox.UseSelectable = true;
            // 
            // EditorialesAEForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 291);
            this.ControlBox = false;
            this.Controls.Add(this.PaisMetroComboBox);
            this.Controls.Add(this.ProvinciasMetroLabel);
            this.Controls.Add(this.CancelMetroButton);
            this.Controls.Add(this.OkMetroButton);
            this.Controls.Add(this.EditorialMetroTextBox);
            this.Controls.Add(this.metroLabel1);
            this.Name = "EditorialesAEForm";
            this.Text = "Agregar Editorial";
            this.Load += new System.EventHandler(this.EditorialesAEForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox EditorialMetroTextBox;
        private MetroFramework.Controls.MetroButton OkMetroButton;
        private MetroFramework.Controls.MetroButton CancelMetroButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MetroFramework.Controls.MetroComboBox PaisMetroComboBox;
        private MetroFramework.Controls.MetroLabel ProvinciasMetroLabel;
    }
}