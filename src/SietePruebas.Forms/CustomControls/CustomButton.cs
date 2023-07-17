using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SietePruebas.Forms.UserControls
{
    public partial class CustomButton : FontAwesome.Sharp.IconButton
    {
        public CustomButton()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            ForeColor = IconColor = Color.White;
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            ForeColor = IconColor = Color.MistyRose;
        }
    }
}
