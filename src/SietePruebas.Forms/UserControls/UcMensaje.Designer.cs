namespace SietePruebas.Forms.UserControls
{
    partial class UcMensaje
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
            this.TlpGeneral = new System.Windows.Forms.TableLayoutPanel();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblSubtitulo = new System.Windows.Forms.Label();
            this.Linea = new System.Windows.Forms.Label();
            this.TlpGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpGeneral
            // 
            this.TlpGeneral.ColumnCount = 1;
            this.TlpGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpGeneral.Controls.Add(this.Linea, 0, 1);
            this.TlpGeneral.Controls.Add(this.LblSubtitulo, 0, 2);
            this.TlpGeneral.Controls.Add(this.LblTitulo, 0, 0);
            this.TlpGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpGeneral.Location = new System.Drawing.Point(2, 2);
            this.TlpGeneral.Margin = new System.Windows.Forms.Padding(0);
            this.TlpGeneral.Name = "TlpGeneral";
            this.TlpGeneral.RowCount = 3;
            this.TlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.TlpGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpGeneral.Size = new System.Drawing.Size(196, 66);
            this.TlpGeneral.TabIndex = 0;
            // 
            // LblTitulo
            // 
            this.LblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTitulo.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Bold);
            this.LblTitulo.Location = new System.Drawing.Point(3, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(190, 31);
            this.LblTitulo.TabIndex = 1;
            this.LblTitulo.Text = "Titulo";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblSubtitulo
            // 
            this.LblSubtitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblSubtitulo.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F);
            this.LblSubtitulo.Location = new System.Drawing.Point(3, 34);
            this.LblSubtitulo.Name = "LblSubtitulo";
            this.LblSubtitulo.Size = new System.Drawing.Size(190, 32);
            this.LblSubtitulo.TabIndex = 2;
            this.LblSubtitulo.Text = "Subtitulo";
            this.LblSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Linea
            // 
            this.Linea.AutoSize = true;
            this.Linea.BackColor = System.Drawing.Color.MistyRose;
            this.Linea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Linea.Location = new System.Drawing.Point(5, 31);
            this.Linea.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Linea.Name = "Linea";
            this.Linea.Size = new System.Drawing.Size(186, 3);
            this.Linea.TabIndex = 3;
            // 
            // UcMensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.TlpGeneral);
            this.Name = "UcMensaje";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(200, 70);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.TlpGeneral.ResumeLayout(false);
            this.TlpGeneral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpGeneral;
        private System.Windows.Forms.Label LblSubtitulo;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label Linea;
    }
}
