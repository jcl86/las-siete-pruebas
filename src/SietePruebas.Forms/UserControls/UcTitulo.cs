using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SietePruebas.Forms.UserControls
{
    public partial class UcTitulo : UcBase
    {
        public string Titulo
        {
            get => Lbl.Text;
            set => Lbl.Text = value;
        }

        public UcTitulo()
        {
            InitializeComponent();
        }
    }
}
