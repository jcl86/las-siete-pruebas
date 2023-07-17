using SietePruebas.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SietePruebas.Forms.Services
{
    public class CrearJuego
    {
        private Juego juego;

        public CrearJuego()
        {
            juego = new Juego(new MazoTest(), "Jorge");

            ParImpar();
            MayorMenor();
            DentroFuera();
            AcertarPalo();
            Figura();
            LaTienesNoLaTienes();
        }

        private void ParImpar()
        {
            new FrmParImpar(juego.Robar()).ShowDialog();
        }

        private void MayorMenor()
        {
            var miCarta = juego.JugadorTurno().UltimaCarta;
            new FrmMayorMenor(juego.Robar(), miCarta).ShowDialog();
        }

        private void DentroFuera()
        {
            var misCartas = juego.JugadorTurno().GetCartas().ToList();
            new FrmDentoFuera(juego.Robar(), misCartas.ToArray()).ShowDialog();
        }

        private void AcertarPalo()
        {
            new FrmAcertarPalo(juego.Robar()).ShowDialog();
        }

        private void Figura()
        {
            new FrmFigura(juego.Robar()).ShowDialog();
        }

        private void LaTienesNoLaTienes()
        {
            var misCartas = juego.JugadorTurno().GetCartas().ToList();
            new FrmLaTienes(juego.Robar(), misCartas.ToList()).ShowDialog();
        }
    }
}
