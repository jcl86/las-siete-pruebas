using SietePruebas.Core.Model;
using SietePruebas.Forms.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SietePruebas.Forms
{
    public partial class FrmParImpar : FrmApuesta
    {
        protected ApuestaParImpar Apuesta => apuesta as ApuestaParImpar;

        public FrmParImpar(Carta carta)
        {
            InitializeComponent();
            apuesta = new ApuestaParImpar(carta);
            LblInfo.Text = apuesta.Titulo;
        }

        private void BtnPar_Click(object sender, EventArgs e)
        {
            ShowResultDialog(Apuesta.EsPar);
        }

        private void BtnImpar_Click(object sender, EventArgs e)
        {
            ShowResultDialog(Apuesta.EsImpar);
        }
    }
}
