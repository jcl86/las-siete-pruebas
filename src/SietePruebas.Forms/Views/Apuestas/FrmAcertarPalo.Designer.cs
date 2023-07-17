namespace SietePruebas.Forms
{
    partial class FrmAcertarPalo
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
            this.TlpBotones = new System.Windows.Forms.TableLayoutPanel();
            this.ucTitulo1 = new SietePruebas.Forms.UserControls.UcTitulo();
            this.LblInfo = new System.Windows.Forms.Label();
            this.BtnBastos = new SietePruebas.Forms.UserControls.CustomButton();
            this.BtnEspadas = new SietePruebas.Forms.UserControls.CustomButton();
            this.BtnCopas = new SietePruebas.Forms.UserControls.CustomButton();
            this.BtnOros = new SietePruebas.Forms.UserControls.CustomButton();
            this.PbxCard = new System.Windows.Forms.PictureBox();
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
            this.TlpPrincipal.Controls.Add(this.TlpBotones, 0, 2);
            this.TlpPrincipal.Controls.Add(this.ucTitulo1, 0, 0);
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
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpPrincipal.Size = new System.Drawing.Size(298, 358);
            this.TlpPrincipal.TabIndex = 2;
            // 
            // TlpBotones
            // 
            this.TlpBotones.ColumnCount = 2;
            this.TlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpBotones.Controls.Add(this.BtnBastos, 1, 1);
            this.TlpBotones.Controls.Add(this.BtnEspadas, 0, 1);
            this.TlpBotones.Controls.Add(this.BtnCopas, 1, 0);
            this.TlpBotones.Controls.Add(this.BtnOros, 0, 0);
            this.TlpBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpBotones.Location = new System.Drawing.Point(5, 243);
            this.TlpBotones.Margin = new System.Windows.Forms.Padding(0);
            this.TlpBotones.Name = "TlpBotones";
            this.TlpBotones.RowCount = 2;
            this.TlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpBotones.Size = new System.Drawing.Size(288, 80);
            this.TlpBotones.TabIndex = 5;
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
            this.ucTitulo1.Titulo = "Acertar el palo";
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
            // BtnBastos
            // 
            this.BtnBastos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.BtnBastos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnBastos.FlatAppearance.BorderSize = 0;
            this.BtnBastos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BtnBastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBastos.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnBastos.Font = new System.Drawing.Font("Liberation Sans", 11F, System.Drawing.FontStyle.Bold);
            this.BtnBastos.ForeColor = System.Drawing.Color.MistyRose;
            this.BtnBastos.IconChar = FontAwesome.Sharp.IconChar.Screwdriver;
            this.BtnBastos.IconColor = System.Drawing.Color.MistyRose;
            this.BtnBastos.IconSize = 25;
            this.BtnBastos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBastos.Location = new System.Drawing.Point(149, 45);
            this.BtnBastos.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.BtnBastos.Name = "BtnBastos";
            this.BtnBastos.Rotation = 180D;
            this.BtnBastos.Size = new System.Drawing.Size(139, 35);
            this.BtnBastos.TabIndex = 5;
            this.BtnBastos.Text = "Bastos";
            this.BtnBastos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBastos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBastos.UseVisualStyleBackColor = false;
            this.BtnBastos.Click += new System.EventHandler(this.BtnBastos_Click);
            // 
            // BtnEspadas
            // 
            this.BtnEspadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.BtnEspadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnEspadas.FlatAppearance.BorderSize = 0;
            this.BtnEspadas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BtnEspadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEspadas.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnEspadas.Font = new System.Drawing.Font("Liberation Sans", 11F, System.Drawing.FontStyle.Bold);
            this.BtnEspadas.ForeColor = System.Drawing.Color.MistyRose;
            this.BtnEspadas.IconChar = FontAwesome.Sharp.IconChar.Bolt;
            this.BtnEspadas.IconColor = System.Drawing.Color.MistyRose;
            this.BtnEspadas.IconSize = 25;
            this.BtnEspadas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEspadas.Location = new System.Drawing.Point(0, 45);
            this.BtnEspadas.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.BtnEspadas.Name = "BtnEspadas";
            this.BtnEspadas.Rotation = 0D;
            this.BtnEspadas.Size = new System.Drawing.Size(139, 35);
            this.BtnEspadas.TabIndex = 4;
            this.BtnEspadas.Text = "Espadas";
            this.BtnEspadas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEspadas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEspadas.UseVisualStyleBackColor = false;
            this.BtnEspadas.Click += new System.EventHandler(this.BtnEspadas_Click);
            // 
            // BtnCopas
            // 
            this.BtnCopas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.BtnCopas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCopas.FlatAppearance.BorderSize = 0;
            this.BtnCopas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BtnCopas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCopas.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnCopas.Font = new System.Drawing.Font("Liberation Sans", 11F, System.Drawing.FontStyle.Bold);
            this.BtnCopas.ForeColor = System.Drawing.Color.MistyRose;
            this.BtnCopas.IconChar = FontAwesome.Sharp.IconChar.GlassMartini;
            this.BtnCopas.IconColor = System.Drawing.Color.MistyRose;
            this.BtnCopas.IconSize = 25;
            this.BtnCopas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCopas.Location = new System.Drawing.Point(149, 5);
            this.BtnCopas.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.BtnCopas.Name = "BtnCopas";
            this.BtnCopas.Rotation = 0D;
            this.BtnCopas.Size = new System.Drawing.Size(139, 35);
            this.BtnCopas.TabIndex = 2;
            this.BtnCopas.Text = "Copas";
            this.BtnCopas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCopas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCopas.UseVisualStyleBackColor = false;
            this.BtnCopas.Click += new System.EventHandler(this.BtnCopas_Click);
            // 
            // BtnOros
            // 
            this.BtnOros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.BtnOros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnOros.FlatAppearance.BorderSize = 0;
            this.BtnOros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BtnOros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOros.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnOros.Font = new System.Drawing.Font("Liberation Sans", 11F, System.Drawing.FontStyle.Bold);
            this.BtnOros.ForeColor = System.Drawing.Color.MistyRose;
            this.BtnOros.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.BtnOros.IconColor = System.Drawing.Color.MistyRose;
            this.BtnOros.IconSize = 25;
            this.BtnOros.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnOros.Location = new System.Drawing.Point(0, 5);
            this.BtnOros.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.BtnOros.Name = "BtnOros";
            this.BtnOros.Rotation = 0D;
            this.BtnOros.Size = new System.Drawing.Size(139, 35);
            this.BtnOros.TabIndex = 1;
            this.BtnOros.Text = "Oros";
            this.BtnOros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnOros.UseVisualStyleBackColor = false;
            this.BtnOros.Click += new System.EventHandler(this.BtnOros_Click);
            // 
            // PbxCard
            // 
            this.PbxCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PbxCard.Image = global::SietePruebas.Forms.Properties.Resources.trasera;
            this.PbxCard.Location = new System.Drawing.Point(64, 45);
            this.PbxCard.Margin = new System.Windows.Forms.Padding(0);
            this.PbxCard.Name = "PbxCard";
            this.PbxCard.Size = new System.Drawing.Size(169, 198);
            this.PbxCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PbxCard.TabIndex = 3;
            this.PbxCard.TabStop = false;
            // 
            // FrmAcertarPalo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 360);
            this.Controls.Add(this.pPrincipal);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAcertarPalo";
            this.Text = "FrmParImpar";
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
        private System.Windows.Forms.PictureBox PbxCard;
        private System.Windows.Forms.Label LblInfo;
        private System.Windows.Forms.TableLayoutPanel TlpBotones;
        private UserControls.CustomButton BtnBastos;
        private UserControls.CustomButton BtnEspadas;
        private UserControls.CustomButton BtnCopas;
        private UserControls.CustomButton BtnOros;
    }
}