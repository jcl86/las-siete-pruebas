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
    public partial class FrmAcertarPalo : FrmApuesta
    {
        protected ApuestaAcertarPalo Apuesta => apuesta as ApuestaAcertarPalo;

        public FrmAcertarPalo(Carta cartaOculta)
        {
            InitializeComponent();

            apuesta = new ApuestaAcertarPalo(cartaOculta);
            LblInfo.Text = apuesta.Titulo;
        }

        private void BtnOros_Click(object sender, EventArgs e)
        {
            ShowResultDialog(Apuesta.EsOros);
        }

        private void BtnCopas_Click(object sender, EventArgs e)
        {
            ShowResultDialog(Apuesta.EsCopas);
        }

        private void BtnEspadas_Click(object sender, EventArgs e)
        {
            ShowResultDialog(Apuesta.EsEspadas);
        }

        private void BtnBastos_Click(object sender, EventArgs e)
        {
            ShowResultDialog(Apuesta.EsBastos);
        }
    }
}
