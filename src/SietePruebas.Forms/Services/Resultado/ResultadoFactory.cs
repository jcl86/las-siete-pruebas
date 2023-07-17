using SietePruebas.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SietePruebas.Forms.Services
{
    public static class ResultadoFactory
    {
        public static void Create(Form owner, bool acertado, string tituloResultado, Carta carta)
        {
            if (acertado)
                new ResultadoAciertoService(tituloResultado, carta).Execute(owner);
            else new ResultadoFalloService(tituloResultado, carta).Execute(owner);
        }
    }
}
