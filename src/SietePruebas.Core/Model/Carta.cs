using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SietePruebas.Core.Model
{
    public class Carta
    {
        public TipoValor Valor { get; set; }
        public TipoPalo Palo { get; set; }

        public string Ruta => $"_{((int)Valor).ToString()}{Palo.ToString().ToLower()}";

        public Carta(TipoValor valor, TipoPalo palo)
        {
            Valor = valor;
            Palo = palo;
        }

        public bool EsPar => ((int)Valor) % 2 == 0;
        public bool EsImpar => ((int)Valor) % 2 != 0;

        public bool EsMayor(Carta otraCarta) => Valor > otraCarta.Valor;
        public bool EsMenor(Carta otraCarta) => Valor < otraCarta.Valor;
        public bool EsIgual(Carta otraCarta) => otraCarta.Valor == Valor;

        public bool EstaDentro(TipoValor min, TipoValor max) => min < Valor && max > Valor;
        public bool EstaFuera(TipoValor min, TipoValor max) => min > Valor || max < Valor;
        public bool ExactamenteIgual(TipoValor min, TipoValor max) => min == Valor || max == Valor;

        public bool EsPalo(TipoPalo palo) => palo == Palo;

        public bool EsFigura
        {
            get
            {
                switch (Valor)
                {
                    case TipoValor.Sota:
                    case TipoValor.Caballo:
                    case TipoValor.Rey:
                        return true;
                }
                return false;
            }
        }
        

        public override string ToString() => $"{Valor.ToString()} de {Palo.ToString()}";

        public override bool Equals(System.Object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                throw new ArgumentOutOfRangeException("Para comparar una carta debe ser un objeto carta");

            Carta c = (Carta)obj;
            return (c.Valor == Valor && c.Palo == Palo);
        }

        public Carta Copia => new Carta(Valor, Palo);

        public override int GetHashCode() => Valor.GetHashCode() * Palo.GetHashCode();
    }
}
