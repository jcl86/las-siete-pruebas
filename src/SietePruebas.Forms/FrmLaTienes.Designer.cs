namespace SietePruebas.Forms
{
    partial class FrmLaTienes
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
            this.BtnNoLaTengo = new SietePruebas.Forms.UserControls.CustomButton();
            this.BtnLaTengo = new SietePruebas.Forms.UserControls.CustomButton();
            this.LblInfo = new System.Windows.Forms.Label();
            this.TlpCards = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PbxCard2 = new System.Windows.Forms.PictureBox();
            this.PbxCard1 = new System.Windows.Forms.PictureBox();
            this.pPrincipal.SuspendLayout();
            this.TlpPrincipal.SuspendLayout();
            this.TlpBotones.SuspendLayout();
            this.TlpCards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCard1)).BeginInit();
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
            this.TlpPrincipal.Controls.Add(this.LblInfo, 0, 3);
            this.TlpPrincipal.Controls.Add(this.TlpCards, 0, 1);
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
            this.TlpPrincipal.TabIndex = 3;
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
            this.ucTitulo1.Titulo = "¿La tienes, o no la tienes?";
            // 
            // TlpBotones
            // 
            this.TlpBotones.ColumnCount = 2;
            this.TlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TlpBotones.Controls.Add(this.BtnNoLaTengo, 0, 0);
            this.TlpBotones.Controls.Add(this.BtnLaTengo, 0, 0);
            this.TlpBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpBotones.Location = new System.Drawing.Point(5, 288);
            this.TlpBotones.Margin = new System.Windows.Forms.Padding(0);
            this.TlpBotones.Name = "TlpBotones";
            this.TlpBotones.RowCount = 1;
            this.TlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpBotones.Size = new System.Drawing.Size(288, 35);
            this.TlpBotones.TabIndex = 2;
            // 
            // BtnNoLaTengo
            // 
            this.BtnNoLaTengo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.BtnNoLaTengo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnNoLaTengo.FlatAppearance.BorderSize = 0;
            this.BtnNoLaTengo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BtnNoLaTengo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNoLaTengo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnNoLaTengo.Font = new System.Drawing.Font("Liberation Sans", 11F, System.Drawing.FontStyle.Bold);
            this.BtnNoLaTengo.ForeColor = System.Drawing.Color.MistyRose;
            this.BtnNoLaTengo.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.BtnNoLaTengo.IconColor = System.Drawing.Color.MistyRose;
            this.BtnNoLaTengo.IconSize = 25;
            this.BtnNoLaTengo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNoLaTengo.Location = new System.Drawing.Point(149, 0);
            this.BtnNoLaTengo.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.BtnNoLaTengo.Name = "BtnNoLaTengo";
            this.BtnNoLaTengo.Rotation = 0D;
            this.BtnNoLaTengo.Size = new System.Drawing.Size(139, 35);
            this.BtnNoLaTengo.TabIndex = 3;
            this.BtnNoLaTengo.Text = "No la tengo";
            this.BtnNoLaTengo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnNoLaTengo.UseVisualStyleBackColor = false;
            this.BtnNoLaTengo.Click += new System.EventHandler(this.BtnNoLaTengo_Click);
            // 
            // BtnLaTengo
            // 
            this.BtnLaTengo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.BtnLaTengo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnLaTengo.FlatAppearance.BorderSize = 0;
            this.BtnLaTengo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BtnLaTengo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLaTengo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnLaTengo.Font = new System.Drawing.Font("Liberation Sans", 11F, System.Drawing.FontStyle.Bold);
            this.BtnLaTengo.ForeColor = System.Drawing.Color.MistyRose;
            this.BtnLaTengo.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.BtnLaTengo.IconColor = System.Drawing.Color.MistyRose;
            this.BtnLaTengo.IconSize = 25;
            this.BtnLaTengo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLaTengo.Location = new System.Drawing.Point(0, 0);
            this.BtnLaTengo.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.BtnLaTengo.Name = "BtnLaTengo";
            this.BtnLaTengo.Rotation = 0D;
            this.BtnLaTengo.Size = new System.Drawing.Size(139, 35);
            this.BtnLaTengo.TabIndex = 1;
            this.BtnLaTengo.Text = "La tengo";
            this.BtnLaTengo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLaTengo.UseVisualStyleBackColor = false;
            this.BtnLaTengo.Click += new System.EventHandler(this.BtnLaTengo_Click);
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
            this.LblInfo.Text = "Intenta acertar si el valor de la siguiente carta estará entre las cartas que ya " +
    "tienes, o fuera de ese rango ";
            this.LblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TlpCards
            // 
            this.TlpCards.ColumnCount = 3;
            this.TlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TlpCards.Controls.Add(this.pictureBox4, 0, 1);
            this.TlpCards.Controls.Add(this.pictureBox3, 1, 1);
            this.TlpCards.Controls.Add(this.pictureBox2, 2, 0);
            this.TlpCards.Controls.Add(this.pictureBox1, 2, 1);
            this.TlpCards.Controls.Add(this.PbxCard2, 1, 0);
            this.TlpCards.Controls.Add(this.PbxCard1, 0, 0);
            this.TlpCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpCards.Location = new System.Drawing.Point(5, 55);
            this.TlpCards.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.TlpCards.Name = "TlpCards";
            this.TlpCards.RowCount = 2;
            this.TlpCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpCards.Size = new System.Drawing.Size(288, 223);
            this.TlpCards.TabIndex = 5;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Image = global::SietePruebas.Forms.Properties.Resources.trasera;
            this.pictureBox4.Location = new System.Drawing.Point(0, 111);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(96, 112);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = global::SietePruebas.Forms.Properties.Resources.trasera;
            this.pictureBox3.Location = new System.Drawing.Point(96, 111);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(96, 112);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::SietePruebas.Forms.Properties.Resources.trasera;
            this.pictureBox2.Location = new System.Drawing.Point(192, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(96, 111);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::SietePruebas.Forms.Properties.Resources.trasera;
            this.pictureBox1.Location = new System.Drawing.Point(192, 111);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // PbxCard2
            // 
            this.PbxCard2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PbxCard2.Image = global::SietePruebas.Forms.Properties.Resources.trasera;
            this.PbxCard2.Location = new System.Drawing.Point(96, 0);
            this.PbxCard2.Margin = new System.Windows.Forms.Padding(0);
            this.PbxCard2.Name = "PbxCard2";
            this.PbxCard2.Size = new System.Drawing.Size(95, 111);
            this.PbxCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxCard2.TabIndex = 5;
            this.PbxCard2.TabStop = false;
            // 
            // PbxCard1
            // 
            this.PbxCard1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PbxCard1.Image = global::SietePruebas.Forms.Properties.Resources.trasera;
            this.PbxCard1.Location = new System.Drawing.Point(0, 0);
            this.PbxCard1.Margin = new System.Windows.Forms.Padding(0);
            this.PbxCard1.Name = "PbxCard1";
            this.PbxCard1.Size = new System.Drawing.Size(95, 111);
            this.PbxCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxCard1.TabIndex = 4;
            this.PbxCard1.TabStop = false;
            // 
            // FrmLaTienes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(300, 360);
            this.Controls.Add(this.pPrincipal);
            this.Name = "FrmLaTienes";
            this.pPrincipal.ResumeLayout(false);
            this.TlpPrincipal.ResumeLayout(false);
            this.TlpBotones.ResumeLayout(false);
            this.TlpCards.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCard1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pPrincipal;
        private System.Windows.Forms.TableLayoutPanel TlpPrincipal;
        private UserControls.UcTitulo ucTitulo1;
        private System.Windows.Forms.TableLayoutPanel TlpBotones;
        private UserControls.CustomButton BtnNoLaTengo;
        private UserControls.CustomButton BtnLaTengo;
        private System.Windows.Forms.Label LblInfo;
        private System.Windows.Forms.TableLayoutPanel TlpCards;
        private System.Windows.Forms.PictureBox PbxCard2;
        private System.Windows.Forms.PictureBox PbxCard1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
