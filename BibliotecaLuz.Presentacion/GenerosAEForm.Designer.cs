namespace BibliotecaLuz.Presentacion
{
    partial class GenerosAEForm
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
            this.GeneroMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.GeneroMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.CancelMetroButton = new MetroFramework.Controls.MetroButton();
            this.OkMetroButton = new MetroFramework.Controls.MetroButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // GeneroMetroLabel
            // 
            this.GeneroMetroLabel.AutoSize = true;
            this.GeneroMetroLabel.Location = new System.Drawing.Point(46, 95);
            this.GeneroMetroLabel.Name = "GeneroMetroLabel";
            this.GeneroMetroLabel.Size = new System.Drawing.Size(59, 19);
            this.GeneroMetroLabel.TabIndex = 0;
            this.GeneroMetroLabel.Text = "Genero :";
            // 
            // GeneroMetroTextBox
            // 
            // 
            // 
            // 
            this.GeneroMetroTextBox.CustomButton.Image = null;
            this.GeneroMetroTextBox.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.GeneroMetroTextBox.CustomButton.Name = "";
            this.GeneroMetroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.GeneroMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.GeneroMetroTextBox.CustomButton.TabIndex = 1;
            this.GeneroMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.GeneroMetroTextBox.CustomButton.UseSelectable = true;
            this.GeneroMetroTextBox.CustomButton.Visible = false;
            this.GeneroMetroTextBox.Lines = new string[0];
            this.GeneroMetroTextBox.Location = new System.Drawing.Point(122, 90);
            this.GeneroMetroTextBox.MaxLength = 32767;
            this.GeneroMetroTextBox.Name = "GeneroMetroTextBox";
            this.GeneroMetroTextBox.PasswordChar = '\0';
            this.GeneroMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.GeneroMetroTextBox.SelectedText = "";
            this.GeneroMetroTextBox.SelectionLength = 0;
            this.GeneroMetroTextBox.SelectionStart = 0;
            this.GeneroMetroTextBox.ShortcutsEnabled = true;
            this.GeneroMetroTextBox.Size = new System.Drawing.Size(198, 23);
            this.GeneroMetroTextBox.TabIndex = 1;
            this.GeneroMetroTextBox.UseSelectable = true;
            this.GeneroMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.GeneroMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            // GenerosAEForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 243);
            this.Controls.Add(this.CancelMetroButton);
            this.Controls.Add(this.OkMetroButton);
            this.Controls.Add(this.GeneroMetroTextBox);
            this.Controls.Add(this.GeneroMetroLabel);
            this.Name = "GenerosAEForm";
            this.Text = "Agregar Genero";
            this.Load += new System.EventHandler(this.GenerosAEForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel GeneroMetroLabel;
        private MetroFramework.Controls.MetroTextBox GeneroMetroTextBox;
        private MetroFramework.Controls.MetroButton OkMetroButton;
        private MetroFramework.Controls.MetroButton CancelMetroButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}