using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SietePruebas.Core.Model
{
    public class Jugador
    {
        public int Id { get; }
        public string Nombre { get; private set; }
        public int Puntos { get; private set; }
        private List<Carta> cartas;
        public Carta UltimaCarta => cartas.Last();
        public IEnumerable<Carta> GetCartas()
        {
            foreach (var carta in cartas)
                yield return carta.Copia;
        }

        public Jugador(int id, string nombre = null)
        {
            Id = id;
            Nombre = string.IsNullOrWhiteSpace(nombre) ? "Jugador " + id : nombre;
            cartas = new List<Carta>();
            Puntos = 0;
        }
        public override string ToString() => Nombre;

        public override bool Equals(System.Object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                throw new ArgumentOutOfRangeException("Para comparar un jugador debe ser un objeto jugador");
            return ((Jugador)obj).Id == Id;
        }

        public override int GetHashCode() => Id.GetHashCode();

        public void Robar(Carta carta) => cartas.Add(carta);
        
    }
}
