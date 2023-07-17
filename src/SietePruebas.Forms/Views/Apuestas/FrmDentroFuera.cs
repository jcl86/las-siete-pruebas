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
    public partial class FrmDentoFuera : FrmApuesta
    {
        protected ApuestaDentroFuera Apuesta => apuesta as ApuestaDentroFuera;
        public FrmDentoFuera(Carta cartaOculta, params Carta[] misCartas)
        {
            InitializeComponent();

            apuesta = new ApuestaDentroFuera(cartaOculta, misCartas);
            PbxCard1.Image = (Image)Properties.Resources.ResourceManager.GetObject(Apuesta.CartaMenor.Ruta);
            PbxCard2.Image = (Image)Properties.Resources.ResourceManager.GetObject(Apuesta.CartaMayor.Ruta);
            LbIinfo.Text = apuesta.Titulo;
        }

        private void BtnDentro_Click(object sender, EventArgs e)
        {
            ShowResultDialog(Apuesta.Dentro);
        }

        private void BtnFuera_Click(object sender, EventArgs e)
        {
            ShowResultDialog(Apuesta.Fuera);
        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            ShowResultDialog(Apuesta.ExactamenteIgual);
        }
    }
}
