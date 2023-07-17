using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SietePruebas.Forms.UserControls
{
    public partial class UcMensaje : SietePruebas.Forms.UserControls.UcBase
    {
        public string Titulo
        {
            get => LblTitulo.Text;
            set => LblTitulo.Text = value;
        }

        public string SubTitulo
        {
            get => LblSubtitulo.Text;
            set => LblSubtitulo.Text = value;
        }

        public UcMensaje()
        {
            InitializeComponent();
        }

        private void OnPaint(object sender, PaintEventArgs pe)
        {
            var color = Color.FromArgb(214, 48, 49);
           
            ControlPaint.DrawBorder(pe.Graphics, pe.ClipRectangle,
                        color, 1, ButtonBorderStyle.Solid,
                        color, 1, ButtonBorderStyle.Solid,
                        color, 1, ButtonBorderStyle.Solid,
                        color, 1, ButtonBorderStyle.Solid);
        }
    }
}
