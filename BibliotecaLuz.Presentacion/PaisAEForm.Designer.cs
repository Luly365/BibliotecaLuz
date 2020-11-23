namespace BibliotecaLuz.Presentacion
{
    partial class PaisAEForm
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
            this.PaisMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.CancelMetroButton = new MetroFramework.Controls.MetroButton();
            this.OkMetroButton = new MetroFramework.Controls.MetroButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(82, 94);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(34, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Pais:";
            // 
            // PaisMetroTextBox
            // 
            // 
            // 
            // 
            this.PaisMetroTextBox.CustomButton.Image = null;
            this.PaisMetroTextBox.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.PaisMetroTextBox.CustomButton.Name = "";
            this.PaisMetroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PaisMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PaisMetroTextBox.CustomButton.TabIndex = 1;
            this.PaisMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PaisMetroTextBox.CustomButton.UseSelectable = true;
            this.PaisMetroTextBox.CustomButton.Visible = false;
            this.PaisMetroTextBox.Lines = new string[0];
            this.PaisMetroTextBox.Location = new System.Drawing.Point(122, 90);
            this.PaisMetroTextBox.MaxLength = 32767;
            this.PaisMetroTextBox.Name = "PaisMetroTextBox";
            this.PaisMetroTextBox.PasswordChar = '\0';
            this.PaisMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PaisMetroTextBox.SelectedText = "";
            this.PaisMetroTextBox.SelectionLength = 0;
            this.PaisMetroTextBox.SelectionStart = 0;
            this.PaisMetroTextBox.ShortcutsEnabled = true;
            this.PaisMetroTextBox.Size = new System.Drawing.Size(198, 23);
            this.PaisMetroTextBox.TabIndex = 1;
            this.PaisMetroTextBox.UseSelectable = true;
            this.PaisMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PaisMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            // PaisAEForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 243);
            this.Controls.Add(this.CancelMetroButton);
            this.Controls.Add(this.OkMetroButton);
            this.Controls.Add(this.PaisMetroTextBox);
            this.Controls.Add(this.metroLabel1);
            this.Name = "PaisAEForm";
            this.Text = "Agregar Pais";
            this.Load += new System.EventHandler(this.PaisAEForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox PaisMetroTextBox;
        private MetroFramework.Controls.MetroButton OkMetroButton;
        private MetroFramework.Controls.MetroButton CancelMetroButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}