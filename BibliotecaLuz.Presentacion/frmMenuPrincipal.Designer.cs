namespace BibliotecaLuz.Presentacion
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.SalirMetroTile = new MetroFramework.Controls.MetroTile();
            this.PrestamoMetroTile = new MetroFramework.Controls.MetroTile();
            this.SocioMmetroTile = new MetroFramework.Controls.MetroTile();
            this.LibroMetroTile = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // SalirMetroTile
            // 
            this.SalirMetroTile.ActiveControl = null;
            this.SalirMetroTile.BackColor = System.Drawing.Color.Silver;
            this.SalirMetroTile.Location = new System.Drawing.Point(616, 206);
            this.SalirMetroTile.Name = "SalirMetroTile";
            this.SalirMetroTile.Size = new System.Drawing.Size(113, 80);
            this.SalirMetroTile.TabIndex = 5;
            this.SalirMetroTile.Text = "Salir";
            this.SalirMetroTile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SalirMetroTile.TileImage = global::BibliotecaLuz.Presentacion.Properties.Resources.exit_48px;
            this.SalirMetroTile.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SalirMetroTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.SalirMetroTile.UseCustomBackColor = true;
            this.SalirMetroTile.UseSelectable = true;
            this.SalirMetroTile.UseTileImage = true;
            this.SalirMetroTile.Click += new System.EventHandler(this.SalirMetroTile_Click);
            // 
            // PrestamoMetroTile
            // 
            this.PrestamoMetroTile.ActiveControl = null;
            this.PrestamoMetroTile.BackColor = System.Drawing.Color.Silver;
            this.PrestamoMetroTile.Location = new System.Drawing.Point(23, 182);
            this.PrestamoMetroTile.Name = "PrestamoMetroTile";
            this.PrestamoMetroTile.Size = new System.Drawing.Size(258, 72);
            this.PrestamoMetroTile.TabIndex = 4;
            this.PrestamoMetroTile.Text = "Prestamos";
            this.PrestamoMetroTile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PrestamoMetroTile.TileImage = global::BibliotecaLuz.Presentacion.Properties.Resources.prestamos_48px;
            this.PrestamoMetroTile.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PrestamoMetroTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.PrestamoMetroTile.UseCustomBackColor = true;
            this.PrestamoMetroTile.UseSelectable = true;
            this.PrestamoMetroTile.UseTileImage = true;
            // 
            // SocioMmetroTile
            // 
            this.SocioMmetroTile.ActiveControl = null;
            this.SocioMmetroTile.BackColor = System.Drawing.Color.Silver;
            this.SocioMmetroTile.Location = new System.Drawing.Point(161, 99);
            this.SocioMmetroTile.Name = "SocioMmetroTile";
            this.SocioMmetroTile.Size = new System.Drawing.Size(120, 77);
            this.SocioMmetroTile.TabIndex = 3;
            this.SocioMmetroTile.Text = "Socios";
            this.SocioMmetroTile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SocioMmetroTile.TileImage = global::BibliotecaLuz.Presentacion.Properties.Resources.socios_48px;
            this.SocioMmetroTile.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SocioMmetroTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.SocioMmetroTile.UseCustomBackColor = true;
            this.SocioMmetroTile.UseSelectable = true;
            this.SocioMmetroTile.UseTileImage = true;
            this.SocioMmetroTile.Click += new System.EventHandler(this.SocioMmetroTile_Click);
            // 
            // LibroMetroTile
            // 
            this.LibroMetroTile.ActiveControl = null;
            this.LibroMetroTile.BackColor = System.Drawing.Color.Silver;
            this.LibroMetroTile.Location = new System.Drawing.Point(23, 99);
            this.LibroMetroTile.Name = "LibroMetroTile";
            this.LibroMetroTile.Size = new System.Drawing.Size(113, 77);
            this.LibroMetroTile.TabIndex = 2;
            this.LibroMetroTile.Text = "Libros";
            this.LibroMetroTile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LibroMetroTile.TileImage = global::BibliotecaLuz.Presentacion.Properties.Resources.Libros_48px;
            this.LibroMetroTile.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LibroMetroTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.LibroMetroTile.UseCustomBackColor = true;
            this.LibroMetroTile.UseSelectable = true;
            this.LibroMetroTile.UseTileImage = true;
            this.LibroMetroTile.Click += new System.EventHandler(this.LibroMetroTile_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 318);
            this.ControlBox = false;
            this.Controls.Add(this.SalirMetroTile);
            this.Controls.Add(this.PrestamoMetroTile);
            this.Controls.Add(this.SocioMmetroTile);
            this.Controls.Add(this.LibroMetroTile);
            this.Name = "frmMenuPrincipal";
            this.Text = " Menú Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile LibroMetroTile;
        private MetroFramework.Controls.MetroTile SocioMmetroTile;
        private MetroFramework.Controls.MetroTile PrestamoMetroTile;
        private MetroFramework.Controls.MetroTile SalirMetroTile;
    }
}

