namespace SietePruebas.Forms
{
    partial class FrmDentoFuera
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
            this.pPrincipal = new System.Windows.Forms.Panel();
            this.TlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.ucTitulo1 = new SietePruebas.Forms.UserControls.UcTitulo();
            this.TlpBotones = new System.Windows.Forms.TableLayoutPanel();
            this.LbIinfo = new System.Windows.Forms.Label();
            this.TlpCards = new System.Windows.Forms.TableLayoutPanel();
            this.BtnFuera = new SietePruebas.Forms.UserControls.CustomButton();
            this.BtnIgual = new SietePruebas.Forms.UserControls.CustomButton();
            this.BtnDentro = new SietePruebas.Forms.UserControls.CustomButton();
            this.PbxCard2 = new System.Windows.Forms.PictureBox();
            this.PbxCard1 = new System.Windows.Forms.PictureBox();
            this.pPrincipal.SuspendLayout();
            this.TlpPrincipal.SuspendLayout();
            this.TlpBotones.SuspendLayout();
            this.TlpCards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCard1)).BeginInit();
            this.SuspendLayout();
            // 
            // pPrincipal
            // 
            this.pPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pPrincipal.Controls.Add(this.TlpPrincipal);
            this.pPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.pPrincipal.Name = "pPrincipal";
            this.pPrincipal.Size = new System.Drawing.Size(300, 360);
            this.pPrincipal.TabIndex = 1;
            // 
            // TlpPrincipal
            // 
            this.TlpPrincipal.ColumnCount = 1;
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpPrincipal.Controls.Add(this.ucTitulo1, 0, 0);
            this.TlpPrincipal.Controls.Add(this.TlpBotones, 0, 2);
            this.TlpPrincipal.Controls.Add(this.LbIinfo, 0, 3);
            this.TlpPrincipal.Controls.Add(this.TlpCards, 0, 1);
            this.TlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.TlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.TlpPrincipal.Name = "TlpPrincipal";
            this.TlpPrincipal.Padding = new System.Windows.Forms.Padding(5);
            this.TlpPrincipal.RowCount = 4;
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
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
            this.ucTitulo1.Titulo = "¿Dentro o fuera?";
            // 
            // TlpBotones
            // 
            this.TlpBotones.ColumnCount = 2;
            this.TlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TlpBotones.Controls.Add(this.BtnFuera, 0, 0);
            this.TlpBotones.Controls.Add(this.BtnIgual, 0, 1);
            this.TlpBotones.Controls.Add(this.BtnDentro, 0, 0);
            this.TlpBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpBotones.Location = new System.Drawing.Point(5, 243);
            this.TlpBotones.Margin = new System.Windows.Forms.Padding(0);
            this.TlpBotones.Name = "TlpBotones";
            this.TlpBotones.RowCount = 2;
            this.TlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpBotones.Size = new System.Drawing.Size(288, 80);
            this.TlpBotones.TabIndex = 2;
            // 
            // LbIinfo
            // 
            this.LbIinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbIinfo.Font = new System.Drawing.Font("Lucida Sans Unicode", 8F);
            this.LbIinfo.Location = new System.Drawing.Point(5, 323);
            this.LbIinfo.Margin = new System.Windows.Forms.Padding(0);
            this.LbIinfo.Name = "LbIinfo";
            this.LbIinfo.Size = new System.Drawing.Size(288, 30);
            this.LbIinfo.TabIndex = 4;
            this.LbIinfo.Text = "Intenta acertar si el valor de la siguiente carta estará entre las cartas que ya " +
    "tienes, o fuera de ese rango ";
            this.LbIinfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TlpCards
            // 
            this.TlpCards.ColumnCount = 2;
            this.TlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpCards.Controls.Add(this.PbxCard2, 1, 0);
            this.TlpCards.Controls.Add(this.PbxCard1, 0, 0);
            this.TlpCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpCards.Location = new System.Drawing.Point(8, 48);
            this.TlpCards.Name = "TlpCards";
            this.TlpCards.RowCount = 1;
            this.TlpCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpCards.Size = new System.Drawing.Size(282, 192);
            this.TlpCards.TabIndex = 5;
            // 
            // BtnFuera
            // 
            this.BtnFuera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.BtnFuera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnFuera.FlatAppearance.BorderSize = 0;
            this.BtnFuera.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BtnFuera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFuera.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnFuera.Font = new System.Drawing.Font("Liberation Sans", 11F, System.Drawing.FontStyle.Bold);
            this.BtnFuera.ForeColor = System.Drawing.Color.MistyRose;
            this.BtnFuera.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.BtnFuera.IconColor = System.Drawing.Color.MistyRose;
            this.BtnFuera.IconSize = 25;
            this.BtnFuera.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnFuera.Location = new System.Drawing.Point(149, 5);
            this.BtnFuera.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.BtnFuera.Name = "BtnFuera";
            this.BtnFuera.Rotation = 0D;
            this.BtnFuera.Size = new System.Drawing.Size(139, 35);
            this.BtnFuera.TabIndex = 3;
            this.BtnFuera.Text = "Fuera";
            this.BtnFuera.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnFuera.UseVisualStyleBackColor = false;
            this.BtnFuera.Click += new System.EventHandler(this.BtnFuera_Click);
            // 
            // BtnIgual
            // 
            this.BtnIgual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.TlpBotones.SetColumnSpan(this.BtnIgual, 2);
            this.BtnIgual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnIgual.FlatAppearance.BorderSize = 0;
            this.BtnIgual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BtnIgual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIgual.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnIgual.Font = new System.Drawing.Font("Liberation Sans", 11F, System.Drawing.FontStyle.Bold);
            this.BtnIgual.ForeColor = System.Drawing.Color.MistyRose;
            this.BtnIgual.IconChar = FontAwesome.Sharp.IconChar.Equals;
            this.BtnIgual.IconColor = System.Drawing.Color.MistyRose;
            this.BtnIgual.IconSize = 25;
            this.BtnIgual.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnIgual.Location = new System.Drawing.Point(0, 45);
            this.BtnIgual.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.BtnIgual.Name = "BtnIgual";
            this.BtnIgual.Rotation = 0D;
            this.BtnIgual.Size = new System.Drawing.Size(288, 35);
            this.BtnIgual.TabIndex = 2;
            this.BtnIgual.Text = "Exactamente igual";
            this.BtnIgual.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnIgual.UseVisualStyleBackColor = false;
            this.BtnIgual.Click += new System.EventHandler(this.BtnIgual_Click);
            // 
            // BtnDentro
            // 
            this.BtnDentro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.BtnDentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDentro.FlatAppearance.BorderSize = 0;
            this.BtnDentro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BtnDentro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDentro.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnDentro.Font = new System.Drawing.Font("Liberation Sans", 11F, System.Drawing.FontStyle.Bold);
            this.BtnDentro.ForeColor = System.Drawing.Color.MistyRose;
            this.BtnDentro.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.BtnDentro.IconColor = System.Drawing.Color.MistyRose;
            this.BtnDentro.IconSize = 25;
            this.BtnDentro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDentro.Location = new System.Drawing.Point(0, 5);
            this.BtnDentro.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.BtnDentro.Name = "BtnDentro";
            this.BtnDentro.Rotation = 0D;
            this.BtnDentro.Size = new System.Drawing.Size(139, 35);
            this.BtnDentro.TabIndex = 1;
            this.BtnDentro.Text = "Dentro";
            this.BtnDentro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDentro.UseVisualStyleBackColor = false;
            this.BtnDentro.Click += new System.EventHandler(this.BtnDentro_Click);
            // 
            // PbxCard2
            // 
            this.PbxCard2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PbxCard2.Image = global::SietePruebas.Forms.Properties.Resources.trasera;
            this.PbxCard2.Location = new System.Drawing.Point(141, 0);
            this.PbxCard2.Margin = new System.Windows.Forms.Padding(0);
            this.PbxCard2.Name = "PbxCard2";
            this.PbxCard2.Size = new System.Drawing.Size(141, 192);
            this.PbxCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
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
            this.PbxCard1.Size = new System.Drawing.Size(141, 192);
            this.PbxCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PbxCard1.TabIndex = 4;
            this.PbxCard1.TabStop = false;
            // 
            // FrmDentoFuera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 360);
            this.Controls.Add(this.pPrincipal);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDentoFuera";
            this.Text = "FrmMayorMenor";
            this.pPrincipal.ResumeLayout(false);
            this.TlpPrincipal.ResumeLayout(false);
            this.TlpBotones.ResumeLayout(false);
            this.TlpCards.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCard1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pPrincipal;
        private System.Windows.Forms.TableLayoutPanel TlpPrincipal;
        private UserControls.UcTitulo ucTitulo1;
        private System.Windows.Forms.TableLayoutPanel TlpBotones;
        private UserControls.CustomButton BtnIgual;
        private UserControls.CustomButton BtnDentro;
        private System.Windows.Forms.Label LbIinfo;
        private UserControls.CustomButton BtnFuera;
        private System.Windows.Forms.TableLayoutPanel TlpCards;
        private System.Windows.Forms.PictureBox PbxCard2;
        private System.Windows.Forms.PictureBox PbxCard1;
    }
}