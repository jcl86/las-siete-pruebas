namespace SietePruebas.Forms
{
    partial class FrmResultado
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
            this.TlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.BtnOk = new SietePruebas.Forms.UserControls.CustomButton();
            this.Titulo = new SietePruebas.Forms.UserControls.UcTitulo();
            this.PbxCard = new System.Windows.Forms.PictureBox();
            this.Mensaje = new SietePruebas.Forms.UserControls.UcMensaje();
            this.TlpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCard)).BeginInit();
            this.SuspendLayout();
            // 
            // TlpPrincipal
            // 
            this.TlpPrincipal.ColumnCount = 1;
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpPrincipal.Controls.Add(this.BtnOk, 0, 3);
            this.TlpPrincipal.Controls.Add(this.Titulo, 0, 0);
            this.TlpPrincipal.Controls.Add(this.PbxCard, 0, 1);
            this.TlpPrincipal.Controls.Add(this.Mensaje, 0, 2);
            this.TlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.TlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.TlpPrincipal.Name = "TlpPrincipal";
            this.TlpPrincipal.Padding = new System.Windows.Forms.Padding(5);
            this.TlpPrincipal.RowCount = 4;
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TlpPrincipal.Size = new System.Drawing.Size(300, 360);
            this.TlpPrincipal.TabIndex = 2;
            // 
            // BtnOk
            // 
            this.BtnOk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.BtnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnOk.FlatAppearance.BorderSize = 0;
            this.BtnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOk.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnOk.Font = new System.Drawing.Font("Liberation Sans", 11F, System.Drawing.FontStyle.Bold);
            this.BtnOk.ForeColor = System.Drawing.Color.MistyRose;
            this.BtnOk.IconChar = FontAwesome.Sharp.IconChar.Smile;
            this.BtnOk.IconColor = System.Drawing.Color.MistyRose;
            this.BtnOk.IconSize = 30;
            this.BtnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnOk.Location = new System.Drawing.Point(50, 315);
            this.BtnOk.Margin = new System.Windows.Forms.Padding(0);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Rotation = 0D;
            this.BtnOk.Size = new System.Drawing.Size(200, 40);
            this.BtnOk.TabIndex = 6;
            this.BtnOk.Text = "Continuar";
            this.BtnOk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnOk.UseVisualStyleBackColor = false;
            this.BtnOk.Click += new System.EventHandler(this.BtnImpar_Click);
            // 
            // Titulo
            // 
            this.Titulo.BackColor = System.Drawing.Color.MistyRose;
            this.Titulo.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F);
            this.Titulo.Location = new System.Drawing.Point(5, 5);
            this.Titulo.Margin = new System.Windows.Forms.Padding(0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(290, 40);
            this.Titulo.TabIndex = 0;
            this.Titulo.Titulo = "Mensaje";
            // 
            // PbxCard
            // 
            this.PbxCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PbxCard.Image = global::SietePruebas.Forms.Properties.Resources._7oros;
            this.PbxCard.Location = new System.Drawing.Point(65, 55);
            this.PbxCard.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.PbxCard.Name = "PbxCard";
            this.PbxCard.Size = new System.Drawing.Size(169, 170);
            this.PbxCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxCard.TabIndex = 3;
            this.PbxCard.TabStop = false;
            // 
            // Mensaje
            // 
            this.Mensaje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Mensaje.BackColor = System.Drawing.Color.White;
            this.Mensaje.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F);
            this.Mensaje.Location = new System.Drawing.Point(50, 240);
            this.Mensaje.Margin = new System.Windows.Forms.Padding(0);
            this.Mensaje.Name = "Mensaje";
            this.Mensaje.Padding = new System.Windows.Forms.Padding(2);
            this.Mensaje.Size = new System.Drawing.Size(200, 70);
            this.Mensaje.SubTitulo = "Subtitulo";
            this.Mensaje.TabIndex = 5;
            this.Mensaje.Titulo = "Titulo";
            // 
            // FrmResultado
            // 
            this.AcceptButton = this.BtnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnOk;
            this.ClientSize = new System.Drawing.Size(300, 360);
            this.ControlBox = false;
            this.Controls.Add(this.TlpPrincipal);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmResultado";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FrmAcierto";
            this.TlpPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxCard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpPrincipal;
        private UserControls.UcTitulo Titulo;
        private System.Windows.Forms.PictureBox PbxCard;
        private UserControls.UcMensaje Mensaje;
        private UserControls.CustomButton BtnOk;
    }
}