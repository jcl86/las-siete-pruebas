namespace SietePruebas.Forms
{
    partial class FrmMayorMenor
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
            this.BtnMenor = new SietePruebas.Forms.UserControls.CustomButton();
            this.BtnIgual = new SietePruebas.Forms.UserControls.CustomButton();
            this.BtnMayor = new SietePruebas.Forms.UserControls.CustomButton();
            this.PbxCard = new System.Windows.Forms.PictureBox();
            this.pPrincipal.SuspendLayout();
            this.TlpPrincipal.SuspendLayout();
            this.TlpBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCard)).BeginInit();
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
            this.TlpPrincipal.Controls.Add(this.PbxCard, 0, 1);
            this.TlpPrincipal.Controls.Add(this.LbIinfo, 0, 3);
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
            this.ucTitulo1.Titulo = "¿Mayor o menor?";
            // 
            // TlpBotones
            // 
            this.TlpBotones.ColumnCount = 3;
            this.TlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TlpBotones.Controls.Add(this.BtnMenor, 0, 0);
            this.TlpBotones.Controls.Add(this.BtnIgual, 1, 0);
            this.TlpBotones.Controls.Add(this.BtnMayor, 0, 0);
            this.TlpBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpBotones.Location = new System.Drawing.Point(5, 288);
            this.TlpBotones.Margin = new System.Windows.Forms.Padding(0);
            this.TlpBotones.Name = "TlpBotones";
            this.TlpBotones.RowCount = 1;
            this.TlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpBotones.Size = new System.Drawing.Size(288, 35);
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
            this.LbIinfo.Text = "Intenta acertar si la siguiente carta será mayor o menor que la que se muestra (o" +
    " igual)";
            this.LbIinfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnMenor
            // 
            this.BtnMenor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.BtnMenor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnMenor.FlatAppearance.BorderSize = 0;
            this.BtnMenor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BtnMenor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenor.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnMenor.Font = new System.Drawing.Font("Liberation Sans", 11F, System.Drawing.FontStyle.Bold);
            this.BtnMenor.ForeColor = System.Drawing.Color.MistyRose;
            this.BtnMenor.IconChar = FontAwesome.Sharp.IconChar.LessThan;
            this.BtnMenor.IconColor = System.Drawing.Color.MistyRose;
            this.BtnMenor.IconSize = 25;
            this.BtnMenor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnMenor.Location = new System.Drawing.Point(101, 0);
            this.BtnMenor.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.BtnMenor.Name = "BtnMenor";
            this.BtnMenor.Rotation = 0D;
            this.BtnMenor.Size = new System.Drawing.Size(91, 35);
            this.BtnMenor.TabIndex = 3;
            this.BtnMenor.Text = "Menor";
            this.BtnMenor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMenor.UseVisualStyleBackColor = false;
            this.BtnMenor.Click += new System.EventHandler(this.BtnMenor_Click);
            // 
            // BtnIgual
            // 
            this.BtnIgual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
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
            this.BtnIgual.Location = new System.Drawing.Point(197, 0);
            this.BtnIgual.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.BtnIgual.Name = "BtnIgual";
            this.BtnIgual.Rotation = 0D;
            this.BtnIgual.Size = new System.Drawing.Size(91, 35);
            this.BtnIgual.TabIndex = 2;
            this.BtnIgual.Text = "Igual";
            this.BtnIgual.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnIgual.UseVisualStyleBackColor = false;
            this.BtnIgual.Click += new System.EventHandler(this.BtnIgual_Click);
            // 
            // BtnMayor
            // 
            this.BtnMayor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.BtnMayor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnMayor.FlatAppearance.BorderSize = 0;
            this.BtnMayor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BtnMayor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMayor.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnMayor.Font = new System.Drawing.Font("Liberation Sans", 11F, System.Drawing.FontStyle.Bold);
            this.BtnMayor.ForeColor = System.Drawing.Color.MistyRose;
            this.BtnMayor.IconChar = FontAwesome.Sharp.IconChar.GreaterThan;
            this.BtnMayor.IconColor = System.Drawing.Color.MistyRose;
            this.BtnMayor.IconSize = 25;
            this.BtnMayor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnMayor.Location = new System.Drawing.Point(0, 0);
            this.BtnMayor.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.BtnMayor.Name = "BtnMayor";
            this.BtnMayor.Rotation = 0D;
            this.BtnMayor.Size = new System.Drawing.Size(91, 35);
            this.BtnMayor.TabIndex = 1;
            this.BtnMayor.Text = "Mayor";
            this.BtnMayor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMayor.UseVisualStyleBackColor = false;
            this.BtnMayor.Click += new System.EventHandler(this.BtnMayor_Click);
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
            // FrmMayorMenor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 360);
            this.Controls.Add(this.pPrincipal);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMayorMenor";
            this.Text = "FrmMayorMenor";
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
        private UserControls.CustomButton BtnIgual;
        private UserControls.CustomButton BtnMayor;
        private System.Windows.Forms.PictureBox PbxCard;
        private System.Windows.Forms.Label LbIinfo;
        private UserControls.CustomButton BtnMenor;
    }
}