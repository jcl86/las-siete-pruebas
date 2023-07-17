using System;
using System.Collections.Generic;
using System.Linq;

namespace SietePruebas.Core.Model
{
    public abstract class BaseApuesta
    {
        public abstract string Titulo { get; }
        protected List<Carta> CartasJugador;
        public Carta CartaOculta;

        protected BaseApuesta(Carta cartaOculta, params Carta[] cartasJugador)
        {
            CartasJugador = cartasJugador?.ToList() ?? null;
            CartaOculta = cartaOculta ?? throw new Exception($"{nameof(cartaOculta)} no puede ser nulo");
        }

        public abstract string Resultado();
       
    }
}
