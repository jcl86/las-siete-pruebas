using System.Windows.Forms;
using SietePruebas.Core.Model;

namespace SietePruebas.Forms.Services
{
    public class ResultadoFalloService : ResultadoService
    {
        public ResultadoFalloService( string tituloResultado, Carta carta) : base(tituloResultado, carta)
        {
        }

        public override void Execute(Form owner)
        {
            using (var f = new FrmResultado(carta, tituloResultado, false))
            {
                f.ShowDialog(owner);
            }
        }
    }
}
