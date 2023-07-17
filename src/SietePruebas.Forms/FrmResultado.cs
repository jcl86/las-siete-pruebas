using SietePruebas.Core.Model;
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
    public partial class FrmResultado : FrmBase
    {
        public FrmResultado(Carta carta, string titulo, bool acierto, int? numeroTragos = null)
        {
            InitializeComponent();
            PbxCard.Image = (Image)Properties.Resources.ResourceManager.GetObject(carta.Ruta);
            Titulo.Titulo = $"¡{titulo}!";
            if (acierto)
                Acierto(numeroTragos);
            else Fallo(numeroTragos);
        }

        private void Acierto(int? numero)
        {
            Mensaje.Titulo = "Has acertado";
            Mensaje.SubTitulo = $"Mandas beber{(numero.HasValue ? $" {numero.Value} tragos" : "")}";
            BtnOk.Text = "¡Genial!";
            BtnOk.IconChar = FontAwesome.Sharp.IconChar.LaughWink;
        }

        private void Fallo(int? numero)
        {
            Mensaje.Titulo = "Has fallado";
            Mensaje.SubTitulo = $"Bebes{(numero.HasValue ? $" {numero.Value} tragos" : "")}";
            BtnOk.Text = "Oh, vaya...";
            BtnOk.IconChar = FontAwesome.Sharp.IconChar.Meh;
        }

        private void BtnImpar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
