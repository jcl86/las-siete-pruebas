using System.Collections.Generic;

namespace SietePruebas.Core.Model
{
    public class MazoTest : MazoBase
    {
        public MazoTest()
        {
            cartas = new List<Carta>()
            {
                new Carta(TipoValor.Tres, TipoPalo.Espadas),
                new Carta(TipoValor.Cinco, TipoPalo.Bastos),
                new Carta(TipoValor.Cuatro, TipoPalo.Copas),
                new Carta(TipoValor.Caballo, TipoPalo.Oros),
                new Carta(TipoValor.As, TipoPalo.Espadas),
                new Carta(TipoValor.Siete, TipoPalo.Espadas),
            };
        }
    }
}
