﻿namespace BibliotecaLuz.Presentacion
{
    partial class TipoDeDocForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.TipoDeDocMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.cmnTipoDeDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalirMetroButton = new MetroFramework.Controls.MetroButton();
            this.ActualizarMetroButton = new MetroFramework.Controls.MetroButton();
            this.EditarMetroButton = new MetroFramework.Controls.MetroButton();
            this.BorrarMetroButton = new MetroFramework.Controls.MetroButton();
            this.NuevoMetroButton = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TipoDeDocMetroGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.TipoDeDocMetroGrid);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(489, 370);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // TipoDeDocMetroGrid
            // 
            this.TipoDeDocMetroGrid.AllowUserToAddRows = false;
            this.TipoDeDocMetroGrid.AllowUserToDeleteRows = false;
            this.TipoDeDocMetroGrid.AllowUserToResizeRows = false;
            this.TipoDeDocMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TipoDeDocMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TipoDeDocMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.TipoDeDocMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TipoDeDocMetroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TipoDeDocMetroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TipoDeDocMetroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmnTipoDeDoc});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TipoDeDocMetroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.TipoDeDocMetroGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TipoDeDocMetroGrid.EnableHeadersVisualStyles = false;
            this.TipoDeDocMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TipoDeDocMetroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TipoDeDocMetroGrid.Location = new System.Drawing.Point(0, 0);
            this.TipoDeDocMetroGrid.MultiSelect = false;
            this.TipoDeDocMetroGrid.Name = "TipoDeDocMetroGrid";
            this.TipoDeDocMetroGrid.ReadOnly = true;
            this.TipoDeDocMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TipoDeDocMetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TipoDeDocMetroGrid.RowHeadersVisible = false;
            this.TipoDeDocMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.TipoDeDocMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TipoDeDocMetroGrid.Size = new System.Drawing.Size(489, 370);
            this.TipoDeDocMetroGrid.TabIndex = 2;
            // 
            // cmnTipoDeDoc
            // 
            this.cmnTipoDeDoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnTipoDeDoc.HeaderText = "Tipos De Documentos";
            this.cmnTipoDeDoc.Name = "cmnTipoDeDoc";
            this.cmnTipoDeDoc.ReadOnly = true;
            // 
            // SalirMetroButton
            // 
            this.SalirMetroButton.BackgroundImage = global::BibliotecaLuz.Presentacion.Properties.Resources.exit_48px;
            this.SalirMetroButton.Location = new System.Drawing.Point(463, 8);
            this.SalirMetroButton.Name = "SalirMetroButton";
            this.SalirMetroButton.Size = new System.Drawing.Size(46, 46);
            this.SalirMetroButton.TabIndex = 7;
            this.SalirMetroButton.UseSelectable = true;
            this.SalirMetroButton.Click += new System.EventHandler(this.SalirMetroButton_Click);
            // 
            // ActualizarMetroButton
            // 
            this.ActualizarMetroButton.BackgroundImage = global::BibliotecaLuz.Presentacion.Properties.Resources.actualizar_48px;
            this.ActualizarMetroButton.Location = new System.Drawing.Point(411, 8);
            this.ActualizarMetroButton.Name = "ActualizarMetroButton";
            this.ActualizarMetroButton.Size = new System.Drawing.Size(46, 46);
            this.ActualizarMetroButton.TabIndex = 6;
            this.ActualizarMetroButton.UseSelectable = true;
            // 
            // EditarMetroButton
            // 
            this.EditarMetroButton.BackgroundImage = global::BibliotecaLuz.Presentacion.Properties.Resources.editar_48px;
            this.EditarMetroButton.Location = new System.Drawing.Point(307, 8);
            this.EditarMetroButton.Name = "EditarMetroButton";
            this.EditarMetroButton.Size = new System.Drawing.Size(46, 46);
            this.EditarMetroButton.TabIndex = 5;
            this.EditarMetroButton.UseSelectable = true;
            this.EditarMetroButton.Click += new System.EventHandler(this.EditarMetroButton_Click);
            // 
            // BorrarMetroButton
            // 
            this.BorrarMetroButton.BackgroundImage = global::BibliotecaLuz.Presentacion.Properties.Resources.borrar_48px;
            this.BorrarMetroButton.Location = new System.Drawing.Point(359, 8);
            this.BorrarMetroButton.Name = "BorrarMetroButton";
            this.BorrarMetroButton.Size = new System.Drawing.Size(46, 46);
            this.BorrarMetroButton.TabIndex = 4;
            this.BorrarMetroButton.UseSelectable = true;
            this.BorrarMetroButton.Click += new System.EventHandler(this.BorrarMetroButton_Click);
            // 
            // NuevoMetroButton
            // 
            this.NuevoMetroButton.BackgroundImage = global::BibliotecaLuz.Presentacion.Properties.Resources.nuevo_48px;
            this.NuevoMetroButton.Location = new System.Drawing.Point(255, 8);
            this.NuevoMetroButton.Name = "NuevoMetroButton";
            this.NuevoMetroButton.Size = new System.Drawing.Size(46, 46);
            this.NuevoMetroButton.TabIndex = 3;
            this.NuevoMetroButton.UseSelectable = true;
            this.NuevoMetroButton.Click += new System.EventHandler(this.NuevoMetroButton_Click);
            // 
            // TipoDeDocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 450);
            this.ControlBox = false;
            this.Controls.Add(this.SalirMetroButton);
            this.Controls.Add(this.ActualizarMetroButton);
            this.Controls.Add(this.EditarMetroButton);
            this.Controls.Add(this.BorrarMetroButton);
            this.Controls.Add(this.NuevoMetroButton);
            this.Controls.Add(this.metroPanel1);
            this.Name = "TipoDeDocForm";
            this.Text = "Tipos De Documentos";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LocalidadesForm_Load);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TipoDeDocMetroGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroGrid TipoDeDocMetroGrid;
        private MetroFramework.Controls.MetroButton NuevoMetroButton;
        private MetroFramework.Controls.MetroButton BorrarMetroButton;
        private MetroFramework.Controls.MetroButton EditarMetroButton;
        private MetroFramework.Controls.MetroButton ActualizarMetroButton;
        private MetroFramework.Controls.MetroButton SalirMetroButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnTipoDeDoc;
    }
}