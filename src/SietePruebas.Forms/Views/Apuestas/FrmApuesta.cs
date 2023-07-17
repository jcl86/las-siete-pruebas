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
    public partial class FrmApuesta : FrmBase
    {
        protected BaseApuesta apuesta;

        public FrmApuesta()
        {
            InitializeComponent();
        }

        protected void ShowResultDialog(Func<bool> respuesta)
        {
            Visible = false;
            ResultadoFactory.Create(this, respuesta.Invoke(), apuesta.Resultado(), apuesta.CartaOculta);
            Close();
        }
    }
}
