using System;
using System.Collections.Generic;
using System.Linq;

namespace SietePruebas.Core.Model
{
    public class ApuestaMayorMenor : BaseApuesta
    {
        protected Carta CartaJugador => CartasJugador.First();

        public override string Titulo
         => $"Intenta acertar si la siguiente carta será mayor o menor que el {CartaJugador.ToString().ToLower()} (o igual)";

        public ApuestaMayorMenor(Carta cartaOculta, Carta cartaJugador) : base(cartaOculta)
        {
            if (cartaJugador == null)
                throw new Exception("Para hacer esta apuesta, el jugador debe tener solo una carta");

            CartasJugador.Add(cartaJugador);
        }

        public bool EsMayor() => CartaOculta.EsMayor(CartaJugador);
        public bool EsMenor() => CartaOculta.EsMenor(CartaJugador);
        public bool EsIgual() => CartaOculta.EsIgual(CartaJugador);

        public override string Resultado()
        {
            if (EsMayor()) return "Mayor";
            if (EsMenor()) return "Menor";
            return "Igual";
        }
    }
}
