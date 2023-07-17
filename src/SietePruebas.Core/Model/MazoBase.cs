using System;
using System.Collections.Generic;

namespace SietePruebas.Core.Model
{
    public abstract class MazoBase : IMazo
    {
        protected List<Carta> cartas;
        public int NumCartas => cartas.Count;

        public virtual Carta Robar()
        {
            Carta c = cartas.ElementoAleatorio();
            cartas.Remove(c);
            return c;
        }
    }
}
