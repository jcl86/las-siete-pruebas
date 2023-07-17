using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SietePruebas.Core.Model
{
    public class Mazo : MazoBase
    {
        public Mazo()
        {
            cartas = new List<Carta>();
            for (int palo = 1; palo <= 4; palo++)
            {
                for (int valor = 1; valor <= 7; valor++)
                    cartas.Add(new Carta((TipoValor)valor, (TipoPalo)palo));
                for (int valor = 10; valor <= 12; valor++)
                    cartas.Add(new Carta((TipoValor)valor, (TipoPalo)palo));
            }
        }
    }
}
