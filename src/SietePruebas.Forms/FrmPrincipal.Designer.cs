namespace SietePruebas.Forms
{
    partial class FrmPrincipal
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
            this.pPoratadaInt = new System.Windows.Forms.Panel();
            this.BtnPlay = new SietePruebas.Forms.UserControls.CustomButton();
            this.BtnConfig = new SietePruebas.Forms.UserControls.CustomButton();
            this.BtnSalir = new SietePruebas.Forms.UserControls.CustomButton();
            this.pPrincipal.SuspendLayout();
            this.TlpPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pPrincipal
            // 
            this.pPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(117)))));
            this.pPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pPrincipal.Controls.Add(this.TlpPrincipal);
            this.pPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pPrincipal.Name = "pPrincipal";
            this.pPrincipal.Size = new System.Drawing.Size(300, 360);
            this.pPrincipal.TabIndex = 0;
            // 
            // TlpPrincipal
            // 
            this.TlpPrincipal.BackColor = System.Drawing.Color.MistyRose;
            this.TlpPrincipal.ColumnCount = 1;
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpPrincipal.Controls.Add(this.pPoratadaInt, 0, 0);
            this.TlpPrincipal.Controls.Add(this.BtnPlay, 0, 1);
            this.TlpPrincipal.Controls.Add(this.BtnConfig, 0, 2);
            this.TlpPrincipal.Controls.Add(this.BtnSalir, 0, 3);
            this.TlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.TlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.TlpPrincipal.Name = "TlpPrincipal";
            this.TlpPrincipal.RowCount = 4;
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.TlpPrincipal.Size = new System.Drawing.Size(298, 358);
            this.TlpPrincipal.TabIndex = 5;
            // 
            // pPoratadaInt
            // 
            this.pPoratadaInt.BackgroundImage = global::SietePruebas.Forms.Properties.Resources.portada;
            this.pPoratadaInt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pPoratadaInt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPoratadaInt.Location = new System.Drawing.Point(10, 10);
            this.pPoratadaInt.Margin = new System.Windows.Forms.Padding(10);
            this.pPoratadaInt.Name = "pPoratadaInt";
            this.pPoratadaInt.Size = new System.Drawing.Size(278, 158);
            this.pPoratadaInt.TabIndex = 0;
            // 
            // BtnPlay
            // 
            this.BtnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.BtnPlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnPlay.FlatAppearance.BorderSize = 0;
            this.BtnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlay.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnPlay.Font = new System.Drawing.Font("Lucida Sans Unicode", 14F, System.Drawing.FontStyle.Bold);
            this.BtnPlay.ForeColor = System.Drawing.Color.MistyRose;
            this.BtnPlay.IconChar = FontAwesome.Sharp.IconChar.PlayCircle;
            this.BtnPlay.IconColor = System.Drawing.Color.MistyRose;
            this.BtnPlay.IconSize = 36;
            this.BtnPlay.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPlay.Location = new System.Drawing.Point(10, 178);
            this.BtnPlay.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Rotation = 0D;
            this.BtnPlay.Size = new System.Drawing.Size(278, 50);
            this.BtnPlay.TabIndex = 4;
            this.BtnPlay.Text = "JUGAR";
            this.BtnPlay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPlay.UseVisualStyleBackColor = false;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // BtnConfig
            // 
            this.BtnConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.BtnConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnConfig.FlatAppearance.BorderSize = 0;
            this.BtnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfig.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnConfig.Font = new System.Drawing.Font("Lucida Sans Unicode", 14F, System.Drawing.FontStyle.Bold);
            this.BtnConfig.ForeColor = System.Drawing.Color.MistyRose;
            this.BtnConfig.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.BtnConfig.IconColor = System.Drawing.Color.MistyRose;
            this.BtnConfig.IconSize = 36;
            this.BtnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConfig.Location = new System.Drawing.Point(10, 238);
            this.BtnConfig.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.BtnConfig.Name = "BtnConfig";
            this.BtnConfig.Rotation = 0D;
            this.BtnConfig.Size = new System.Drawing.Size(278, 50);
            this.BtnConfig.TabIndex = 5;
            this.BtnConfig.Text = "CONFIGURACIÓN";
            this.BtnConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConfig.UseVisualStyleBackColor = false;
            this.BtnConfig.Click += new System.EventHandler(this.BtnConfig_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.BtnSalir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnSalir.Font = new System.Drawing.Font("Lucida Sans Unicode", 14F, System.Drawing.FontStyle.Bold);
            this.BtnSalir.ForeColor = System.Drawing.Color.MistyRose;
            this.BtnSalir.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.BtnSalir.IconColor = System.Drawing.Color.MistyRose;
            this.BtnSalir.IconSize = 36;
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalir.Location = new System.Drawing.Point(10, 298);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Rotation = 0D;
            this.BtnSalir.Size = new System.Drawing.Size(278, 50);
            this.BtnSalir.TabIndex = 6;
            this.BtnSalir.Text = "SALIR";
            this.BtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 360);
            this.Controls.Add(this.pPrincipal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Las siete pruebas";
            this.pPrincipal.ResumeLayout(false);
            this.TlpPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pPrincipal;
        private System.Windows.Forms.Panel pPoratadaInt;
        private System.Windows.Forms.TableLayoutPanel TlpPrincipal;
        private UserControls.CustomButton BtnPlay;
        private UserControls.CustomButton BtnConfig;
        private UserControls.CustomButton BtnSalir;
    }
}

