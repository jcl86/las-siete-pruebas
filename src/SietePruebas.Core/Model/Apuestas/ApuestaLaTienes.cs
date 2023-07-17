using System;
using System.Collections.Generic;
using System.Linq;

namespace SietePruebas.Core.Model
{
    public class ApuestaLaTienes : BaseApuesta
    {
        private bool EstaRealmente => CartasJugador.Any(x => x.Valor == CartaOculta.Valor);

        public override string Titulo => $"Intenta acertar si la siguiente carta es una de las que tienes ({CartasDelJugador()})";

        public ApuestaLaTienes(Carta cartaOculta, IEnumerable<Carta> cartasJugador) : base(cartaOculta, cartasJugador.ToArray())
        {
            if (cartasJugador == null || cartasJugador.Count() < 1)
                throw new Exception("Para hacer esta apuesta, el jugador debe tener al menos una carta");
        }
        public bool LaTienes() => EstaRealmente;
        public bool NoLaTienes() => !EstaRealmente;

        public override string Resultado()
        {
            if (EstaRealmente)
                return "La tienes";
            return "No la tienes";
        }

        private string CartasDelJugador()
        {
            return string.Join(", ", CartasJugador.OrderBy(x=> x.Valor).Select(x => x.Valor.ToString()));
        }
    }
}
