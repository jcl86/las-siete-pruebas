namespace SietePruebas.Forms
{
    partial class FrmParImpar
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
            this.ucTitulo1 = new SietePruebas.Forms.UserControls.UcTitulo();
            this.TlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.TlpBotones = new System.Windows.Forms.TableLayoutPanel();
            this.LblInfo = new System.Windows.Forms.Label();
            this.pPrincipal = new System.Windows.Forms.Panel();
            this.BtnImpar = new SietePruebas.Forms.UserControls.CustomButton();
            this.BtnPar = new SietePruebas.Forms.UserControls.CustomButton();
            this.PbxCard = new System.Windows.Forms.PictureBox();
            this.TlpPrincipal.SuspendLayout();
            this.TlpBotones.SuspendLayout();
            this.pPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCard)).BeginInit();
            this.SuspendLayout();
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
            this.ucTitulo1.Titulo = "¿Par o impar?";
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
            this.TlpPrincipal.TabIndex = 1;
            // 
            // TlpBotones
            // 
            this.TlpBotones.ColumnCount = 2;
            this.TlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpBotones.Controls.Add(this.BtnImpar, 1, 0);
            this.TlpBotones.Controls.Add(this.BtnPar, 0, 0);
            this.TlpBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpBotones.Location = new System.Drawing.Point(5, 288);
            this.TlpBotones.Margin = new System.Windows.Forms.Padding(0);
            this.TlpBotones.Name = "TlpBotones";
            this.TlpBotones.RowCount = 1;
            this.TlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpBotones.Size = new System.Drawing.Size(288, 35);
            this.TlpBotones.TabIndex = 2;
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
            // pPrincipal
            // 
            this.pPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pPrincipal.Controls.Add(this.TlpPrincipal);
            this.pPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.pPrincipal.Name = "pPrincipal";
            this.pPrincipal.Size = new System.Drawing.Size(300, 360);
            this.pPrincipal.TabIndex = 2;
            // 
            // BtnImpar
            // 
            this.BtnImpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.BtnImpar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnImpar.FlatAppearance.BorderSize = 0;
            this.BtnImpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BtnImpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImpar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnImpar.Font = new System.Drawing.Font("Liberation Sans", 11F, System.Drawing.FontStyle.Bold);
            this.BtnImpar.ForeColor = System.Drawing.Color.MistyRose;
            this.BtnImpar.IconChar = FontAwesome.Sharp.IconChar.CircleNotch;
            this.BtnImpar.IconColor = System.Drawing.Color.MistyRose;
            this.BtnImpar.IconSize = 25;
            this.BtnImpar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnImpar.Location = new System.Drawing.Point(149, 0);
            this.BtnImpar.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.BtnImpar.Name = "BtnImpar";
            this.BtnImpar.Rotation = 0D;
            this.BtnImpar.Size = new System.Drawing.Size(139, 35);
            this.BtnImpar.TabIndex = 2;
            this.BtnImpar.Text = "Impar";
            this.BtnImpar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnImpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnImpar.UseVisualStyleBackColor = false;
            this.BtnImpar.Click += new System.EventHandler(this.BtnImpar_Click);
            // 
            // BtnPar
            // 
            this.BtnPar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.BtnPar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnPar.FlatAppearance.BorderSize = 0;
            this.BtnPar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BtnPar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnPar.Font = new System.Drawing.Font("Liberation Sans", 11F, System.Drawing.FontStyle.Bold);
            this.BtnPar.ForeColor = System.Drawing.Color.MistyRose;
            this.BtnPar.IconChar = FontAwesome.Sharp.IconChar.CircleNotch;
            this.BtnPar.IconColor = System.Drawing.Color.MistyRose;
            this.BtnPar.IconSize = 25;
            this.BtnPar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPar.Location = new System.Drawing.Point(0, 0);
            this.BtnPar.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.BtnPar.Name = "BtnPar";
            this.BtnPar.Rotation = 0D;
            this.BtnPar.Size = new System.Drawing.Size(139, 35);
            this.BtnPar.TabIndex = 1;
            this.BtnPar.Text = "Par";
            this.BtnPar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPar.UseVisualStyleBackColor = false;
            this.BtnPar.Click += new System.EventHandler(this.BtnPar_Click);
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
            // FrmParImpar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 360);
            this.Controls.Add(this.pPrincipal);
            this.Name = "FrmParImpar";
            this.Text = "FrmParImpar";
            this.TlpPrincipal.ResumeLayout(false);
            this.TlpBotones.ResumeLayout(false);
            this.pPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxCard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.UcTitulo ucTitulo1;
        private System.Windows.Forms.TableLayoutPanel TlpPrincipal;
        private System.Windows.Forms.TableLayoutPanel TlpBotones;
        private UserControls.CustomButton BtnImpar;
        private UserControls.CustomButton BtnPar;
        private System.Windows.Forms.PictureBox PbxCard;
        private System.Windows.Forms.Label LblInfo;
        private System.Windows.Forms.Panel pPrincipal;
    }
}