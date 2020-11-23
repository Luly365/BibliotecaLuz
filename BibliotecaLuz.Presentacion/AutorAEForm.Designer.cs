namespace BibliotecaLuz.Presentacion
{
    partial class AutorAEForm
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
            this.AutorMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.AutorMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.CancelMetroButton = new MetroFramework.Controls.MetroButton();
            this.OkMetroButton = new MetroFramework.Controls.MetroButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // AutorMetroLabel
            // 
            this.AutorMetroLabel.AutoSize = true;
            this.AutorMetroLabel.Location = new System.Drawing.Point(46, 95);
            this.AutorMetroLabel.Name = "AutorMetroLabel";
            this.AutorMetroLabel.Size = new System.Drawing.Size(49, 19);
            this.AutorMetroLabel.TabIndex = 0;
            this.AutorMetroLabel.Text = "Autor :";
            // 
            // AutorMetroTextBox
            // 
            // 
            // 
            // 
            this.AutorMetroTextBox.CustomButton.Image = null;
            this.AutorMetroTextBox.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.AutorMetroTextBox.CustomButton.Name = "";
            this.AutorMetroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.AutorMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AutorMetroTextBox.CustomButton.TabIndex = 1;
            this.AutorMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AutorMetroTextBox.CustomButton.UseSelectable = true;
            this.AutorMetroTextBox.CustomButton.Visible = false;
            this.AutorMetroTextBox.Lines = new string[0];
            this.AutorMetroTextBox.Location = new System.Drawing.Point(122, 90);
            this.AutorMetroTextBox.MaxLength = 32767;
            this.AutorMetroTextBox.Name = "AutorMetroTextBox";
            this.AutorMetroTextBox.PasswordChar = '\0';
            this.AutorMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AutorMetroTextBox.SelectedText = "";
            this.AutorMetroTextBox.SelectionLength = 0;
            this.AutorMetroTextBox.SelectionStart = 0;
            this.AutorMetroTextBox.ShortcutsEnabled = true;
            this.AutorMetroTextBox.Size = new System.Drawing.Size(198, 23);
            this.AutorMetroTextBox.TabIndex = 1;
            this.AutorMetroTextBox.UseSelectable = true;
            this.AutorMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AutorMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CancelMetroButton
            // 
            this.CancelMetroButton.BackgroundImage = global::BibliotecaLuz.Presentacion.Properties.Resources.borrar_48px;
            this.CancelMetroButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelMetroButton.Location = new System.Drawing.Point(245, 144);
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
            this.OkMetroButton.Location = new System.Drawing.Point(46, 144);
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
            // AutorAEForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 243);
            this.ControlBox = false;
            this.Controls.Add(this.CancelMetroButton);
            this.Controls.Add(this.OkMetroButton);
            this.Controls.Add(this.AutorMetroTextBox);
            this.Controls.Add(this.AutorMetroLabel);
            this.Name = "AutorAEForm";
            this.Text = "Agregar Autor";
            this.Load += new System.EventHandler(this.GenerosAEForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel AutorMetroLabel;
        private MetroFramework.Controls.MetroTextBox AutorMetroTextBox;
        private MetroFramework.Controls.MetroButton OkMetroButton;
        private MetroFramework.Controls.MetroButton CancelMetroButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}