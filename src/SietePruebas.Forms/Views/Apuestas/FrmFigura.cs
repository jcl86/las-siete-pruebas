using SietePruebas.Core.Model;
using SietePruebas.Forms.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SietePruebas.Forms
{
    public partial class FrmFigura : FrmApuesta
    {
        protected ApuestaFiguras Apuesta => apuesta as ApuestaFiguras;

        public FrmFigura(Carta cartaOculta)
        {
            InitializeComponent();
            apuesta = new ApuestaFiguras(cartaOculta);
            LblInfo.Text = apuesta.Titulo;
        }

        private void BtnFigura_Click(object sender, EventArgs e)
        {
            ShowResultDialog(Apuesta.Figura);
        }

        private void BtnNoFigura_Click(object sender, EventArgs e)
        {
            ShowResultDialog(Apuesta.NoFigura);
        }
    }
}
