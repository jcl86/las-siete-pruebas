namespace SietePruebas.Forms.UserControls
{
    partial class UcTitulo
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TlpGeneral = new System.Windows.Forms.TableLayoutPanel();
            this.Lbl = new System.Windows.Forms.Label();
            this.Linea = new System.Windows.Forms.Label();
            this.TlpGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpGeneral
            // 
            this.TlpGeneral.ColumnCount = 1;
            this.TlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpGeneral.Controls.Add(this.Lbl, 0, 0);
            this.TlpGeneral.Controls.Add(this.Linea, 0, 1);
            this.TlpGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpGeneral.Location = new System.Drawing.Point(0, 0);
            this.TlpGeneral.Margin = new System.Windows.Forms.Padding(0);
            this.TlpGeneral.Name = "TlpGeneral";
            this.TlpGeneral.RowCount = 2;
            this.TlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.TlpGeneral.Size = new System.Drawing.Size(300, 40);
            this.TlpGeneral.TabIndex = 0;
            // 
            // Lbl
            // 
            this.Lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl.Font = new System.Drawing.Font("Lucida Sans Unicode", 14F);
            this.Lbl.Location = new System.Drawing.Point(3, 0);
            this.Lbl.Name = "Lbl";
            this.Lbl.Size = new System.Drawing.Size(294, 36);
            this.Lbl.TabIndex = 0;
            this.Lbl.Text = "Titulo";
            this.Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Linea
            // 
            this.Linea.AutoSize = true;
            this.Linea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.Linea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Linea.Location = new System.Drawing.Point(0, 36);
            this.Linea.Margin = new System.Windows.Forms.Padding(0);
            this.Linea.Name = "Linea";
            this.Linea.Size = new System.Drawing.Size(300, 4);
            this.Linea.TabIndex = 1;
            // 
            // UcTitulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TlpGeneral);
            this.Name = "UcTitulo";
            this.Size = new System.Drawing.Size(300, 40);
            this.TlpGeneral.ResumeLayout(false);
            this.TlpGeneral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpGeneral;
        private System.Windows.Forms.Label Lbl;
        private System.Windows.Forms.Label Linea;
    }
}
