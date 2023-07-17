namespace SietePruebas.Core.Model
{
    public class ApuestaParImpar : BaseApuesta
    {
        public override string Titulo => "Intenta acertar si la siguiente carta será par o impar";

        public ApuestaParImpar(Carta cartaOculta) : base(cartaOculta) { }

        public bool EsPar() => CartaOculta.EsPar;
        public bool EsImpar() => CartaOculta.EsImpar;

        public override string Resultado()
        {
            if (CartaOculta.EsPar)
                return "Par";
            else return "Impar";
        }

        
    }
}
