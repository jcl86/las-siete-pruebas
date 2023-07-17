using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SietePruebas.Core.Model
{
    public class Juego
    {
        public List<Jugador> Jugadores { get; set; }
        public IMazo MazoCartas { get; set; }
        public int Turno { get; set; }

        public Juego(IMazo mazo, params string[] jugadores)
        {
            int i = 1;
            Jugadores = new List<Jugador>();
            foreach (string jug in jugadores)
                Jugadores.Add(new Jugador (i++, jug));
            MazoCartas = mazo;
        }

        public void Reiniciar(IMazo mazo)
        {
            for (int i = 0; i < Jugadores.Count; i++)
                Jugadores[i] = new Jugador(i + 1, Jugadores.ToString());
            MazoCartas = mazo;
        }

        public void AvanzarTurno() => Turno = (Turno == Jugadores.Count - 1) ? 0 : Turno + 1;
        public Jugador JugadorTurno() => Jugadores[Turno];
        public Carta Robar()
        {
            var carta = MazoCartas.Robar();
            JugadorTurno().Robar(carta);
            return carta;
        }
    }
}
