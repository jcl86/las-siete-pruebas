using System;
using System.Collections.Generic;
using System.Linq;

namespace SietePruebas.Core.Model
{
    public class ApuestaDentroFuera : BaseApuesta
    {
        public Carta CartaMenor => CartasJugador.First();
        public Carta CartaMayor => CartasJugador.Last();

        public ApuestaDentroFuera(Carta cartaOculta, IEnumerable<Carta> cartasJugador) : base(cartaOculta, cartasJugador.ToArray())
        {
            if (cartasJugador == null || cartasJugador.Count() != 2)
                throw new Exception("Para hacer esta apuesta, el jugador debe tener dos cartas");
            CartasJugador = CartasJugador.OrderBy(x => x.Valor).ToList();
        }

        public bool Dentro() => CartaOculta.EstaDentro(CartaMenor.Valor, CartaMayor.Valor);
        public bool Fuera() => CartaOculta.EstaFuera(CartaMenor.Valor, CartaMayor.Valor);
        public bool ExactamenteIgual() => CartaOculta.ExactamenteIgual(CartaMenor.Valor, CartaMayor.Valor);

        public override string Resultado()
        {
            if (Dentro()) return "Dentro";
            if (Fuera()) return "Fuera";
            return "Exactamente igual";
        }

        public override string Titulo
            => $"Intenta acertar si el valor de la siguiente carta estará entre el {CartaMenor.ToString().ToLower()} y el {CartaMayor.ToString().ToLower()}";
    }
}
