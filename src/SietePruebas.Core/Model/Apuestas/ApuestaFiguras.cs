namespace SietePruebas.Core.Model
{
    public class ApuestaFiguras : BaseApuesta
    {
        public ApuestaFiguras(Carta cartaOculta) : base(cartaOculta) { }

        public override string Titulo => "Intenta hacertar si la siguiente carta será una figura (Sota, caballo o rey)";

        public bool Figura() => CartaOculta.EsFigura;
        public bool NoFigura() => !CartaOculta.EsFigura;

        public override string Resultado()
        {
            if (Figura()) return "Es figura";
            return "No es figura";
        }
    }
}
