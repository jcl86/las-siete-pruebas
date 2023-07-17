using SietePruebas.Core.Model;
using System.Windows.Forms;

namespace SietePruebas.Forms.Services
{
    public abstract class ResultadoService
    {
        protected readonly string tituloResultado;
        protected readonly Carta carta;

        public ResultadoService(string tituloResultado, Carta carta)
        {
            this.tituloResultado = tituloResultado;
            this.carta = carta;
        }

        public abstract void Execute(Form owner);
        //Aquí lanzar evento con la respuesta
    }
}
