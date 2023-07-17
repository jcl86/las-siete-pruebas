using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SietePruebas.Core.Model;
using SietePruebas.Forms.Services;

namespace SietePruebas.Forms
{
    public partial class FrmPrincipal : FrmBase
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e) => Application.Exit();

        private void BtnConfig_Click(object sender, EventArgs e)
        {
            Visible = false;

            Visible = true;
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            Visible = false;
            new CrearJuego();
            Visible = true;
        }

      
    }
}
