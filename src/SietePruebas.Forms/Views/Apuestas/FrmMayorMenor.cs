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
    public partial class FrmMayorMenor : FrmApuesta
    {
        protected ApuestaMayorMenor Apuesta => apuesta as ApuestaMayorMenor;

        public FrmMayorMenor(Carta cartaOculta, Carta miCarta)
        {
            InitializeComponent();
            apuesta = new ApuestaMayorMenor(cartaOculta, miCarta);
            PbxCard.Image = (Image)Properties.Resources.ResourceManager.GetObject(miCarta.Ruta);
            LbIinfo.Text = apuesta.Titulo;
        }

        private void BtnMayor_Click(object sender, EventArgs e)
        {
            ShowResultDialog(Apuesta.EsMayor);
        }

        private void BtnMenor_Click(object sender, EventArgs e)
        {
            ShowResultDialog(Apuesta.EsMenor);
        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            ShowResultDialog(Apuesta.EsIgual);
        }
    }
}
