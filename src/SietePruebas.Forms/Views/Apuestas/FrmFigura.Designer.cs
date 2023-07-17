namespace SietePruebas.Forms
{
    partial class FrmFigura
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
            this.pPrincipal = new System.Windows.Forms.Panel();
            this.TlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.ucTitulo1 = new SietePruebas.Forms.UserControls.UcTitulo();
            this.TlpBotones = new System.Windows.Forms.TableLayoutPanel();
            this.BtnNoFigura = new SietePruebas.Forms.UserControls.CustomButton();
            this.BtnFigura = new SietePruebas.Forms.UserControls.CustomButton();
            this.PbxCard = new System.Windows.Forms.PictureBox();
            this.LblInfo = new System.Windows.Forms.Label();
            this.pPrincipal.SuspendLayout();
            this.TlpPrincipal.SuspendLayout();
            this.TlpBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCard)).BeginInit();
            this.SuspendLayout();
            // 
            // pPrincipal
            // 
            this.pPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pPrincipal.Controls.Add(this.TlpPrincipal);
            this.pPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.pPrincipal.Name = "pPrincipal";
            this.pPrincipal.Size = new System.Drawing.Size(300, 360);
            this.pPrincipal.TabIndex = 0;
            // 
            // TlpPrincipal
            // 
            this.TlpPrincipal.ColumnCount = 1;
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpPrincipal.Controls.Add(this.ucTitulo1, 0, 0);
            this.TlpPrincipal.Controls.Add(this.TlpBotones, 0, 2);
            this.TlpPrincipal.Controls.Add(this.PbxCard, 0, 1);
            this.TlpPrincipal.Controls.Add(this.LblInfo, 0, 3);
            this.TlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.TlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.TlpPrincipal.Name = "TlpPrincipal";
            this.TlpPrincipal.Padding = new System.Windows.Forms.Padding(5);
            this.TlpPrincipal.RowCount = 4;
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TlpPrincipal.Size = new System.Drawing.Size(298, 358);
            this.TlpPrincipal.TabIndex = 2;
            // 
            // ucTitulo1
            // 
            this.ucTitulo1.BackColor = System.Drawing.Color.MistyRose;
            this.ucTitulo1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F);
            this.ucTitulo1.Location = new System.Drawing.Point(5, 5);
            this.ucTitulo1.Margin = new System.Windows.Forms.Padding(0);
            this.ucTitulo1.Name = "ucTitulo1";
            this.ucTitulo1.Size = new System.Drawing.Size(288, 40);
            this.ucTitulo1.TabIndex = 0;
            this.ucTitulo1.Titulo = "¿Figura, o no figura?";
            // 
            // TlpBotones
            // 
            this.TlpBotones.ColumnCount = 2;
            this.TlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpBotones.Controls.Add(this.BtnNoFigura, 1, 0);
            this.TlpBotones.Controls.Add(this.BtnFigura, 0, 0);
            this.TlpBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpBotones.Location = new System.Drawing.Point(5, 288);
            this.TlpBotones.Margin = new System.Windows.Forms.Padding(0);
            this.TlpBotones.Name = "TlpBotones";
            this.TlpBotones.RowCount = 1;
            this.TlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpBotones.Size = new System.Drawing.Size(288, 35);
            this.TlpBotones.TabIndex = 2;
            // 
            // BtnNoFigura
            // 
            this.BtnNoFigura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.BtnNoFigura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnNoFigura.FlatAppearance.BorderSize = 0;
            this.BtnNoFigura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BtnNoFigura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNoFigura.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnNoFigura.Font = new System.Drawing.Font("Liberation Sans", 11F, System.Drawing.FontStyle.Bold);
            this.BtnNoFigura.ForeColor = System.Drawing.Color.MistyRose;
            this.BtnNoFigura.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.BtnNoFigura.IconColor = System.Drawing.Color.MistyRose;
            this.BtnNoFigura.IconSize = 25;
            this.BtnNoFigura.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNoFigura.Location = new System.Drawing.Point(149, 0);
            this.BtnNoFigura.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.BtnNoFigura.Name = "BtnNoFigura";
            this.BtnNoFigura.Rotation = 0D;
            this.BtnNoFigura.Size = new System.Drawing.Size(139, 35);
            this.BtnNoFigura.TabIndex = 2;
            this.BtnNoFigura.Text = "No figura";
            this.BtnNoFigura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNoFigura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnNoFigura.UseVisualStyleBackColor = false;
            this.BtnNoFigura.Click += new System.EventHandler(this.BtnNoFigura_Click);
            // 
            // BtnFigura
            // 
            this.BtnFigura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.BtnFigura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnFigura.FlatAppearance.BorderSize = 0;
            this.BtnFigura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BtnFigura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFigura.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnFigura.Font = new System.Drawing.Font("Liberation Sans", 11F, System.Drawing.FontStyle.Bold);
            this.BtnFigura.ForeColor = System.Drawing.Color.MistyRose;
            this.BtnFigura.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.BtnFigura.IconColor = System.Drawing.Color.MistyRose;
            this.BtnFigura.IconSize = 25;
            this.BtnFigura.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnFigura.Location = new System.Drawing.Point(0, 0);
            this.BtnFigura.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.BtnFigura.Name = "BtnFigura";
            this.BtnFigura.Rotation = 0D;
            this.BtnFigura.Size = new System.Drawing.Size(139, 35);
            this.BtnFigura.TabIndex = 1;
            this.BtnFigura.Text = "Figura";
            this.BtnFigura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFigura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnFigura.UseVisualStyleBackColor = false;
            this.BtnFigura.Click += new System.EventHandler(this.BtnFigura_Click);
            // 
            // PbxCard
            // 
            this.PbxCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PbxCard.Image = global::SietePruebas.Forms.Properties.Resources.trasera;
            this.PbxCard.Location = new System.Drawing.Point(64, 64);
            this.PbxCard.Margin = new System.Windows.Forms.Padding(0);
            this.PbxCard.Name = "PbxCard";
            this.PbxCard.Size = new System.Drawing.Size(169, 205);
            this.PbxCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PbxCard.TabIndex = 3;
            this.PbxCard.TabStop = false;
            // 
            // LblInfo
            // 
            this.LblInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblInfo.Font = new System.Drawing.Font("Lucida Sans Unicode", 8F);
            this.LblInfo.Location = new System.Drawing.Point(5, 323);
            this.LblInfo.Margin = new System.Windows.Forms.Padding(0);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(288, 30);
            this.LblInfo.TabIndex = 4;
            this.LblInfo.Text = "Intenta acertar si la siguiente carta será par o impar";
            this.LblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmFigura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(300, 360);
            this.Controls.Add(this.pPrincipal);
            this.Name = "FrmFigura";
            this.pPrincipal.ResumeLayout(false);
            this.TlpPrincipal.ResumeLayout(false);
            this.TlpBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxCard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pPrincipal;
        private System.Windows.Forms.TableLayoutPanel TlpPrincipal;
        private UserControls.UcTitulo ucTitulo1;
        private System.Windows.Forms.TableLayoutPanel TlpBotones;
        private UserControls.CustomButton BtnNoFigura;
        private UserControls.CustomButton BtnFigura;
        private System.Windows.Forms.PictureBox PbxCard;
        private System.Windows.Forms.Label LblInfo;
    }
}
