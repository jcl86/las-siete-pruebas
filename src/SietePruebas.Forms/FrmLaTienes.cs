using SietePruebas.Core.Model;
using SietePruebas.Forms.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SietePruebas.Forms
{
    public partial class FrmLaTienes : FrmApuesta
    {
        private ApuestaLaTienes Apuesta => apuesta as ApuestaLaTienes;

        public FrmLaTienes(Carta cartaOculta, List<Carta> cartasJugador)
        {
            InitializeComponent();
            apuesta = new ApuestaLaTienes(cartaOculta, cartasJugador.ToList());

            int i = 0;
            foreach (PictureBox pbx in TlpCards.Controls)
            {
                if (i < cartasJugador.Count)
                {
                    pbx.Image = (Image)Properties.Resources.ResourceManager.GetObject(cartasJugador[i].Ruta);
                }
                else pbx.Image = null;
                i++;
            }
            LblInfo.Text = apuesta.Titulo;
        }

        private void BtnLaTengo_Click(object sender, EventArgs e)
        {
            ShowResultDialog(Apuesta.LaTienes);
        }

        private void BtnNoLaTengo_Click(object sender, EventArgs e)
        {
            ShowResultDialog(Apuesta.NoLaTienes);
        }
    }
}
