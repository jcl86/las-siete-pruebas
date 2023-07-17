namespace SietePruebas.Core.Model
{
    public class ApuestaAcertarPalo : BaseApuesta
    {
        public override string Titulo
            => $"Intenta acertar el palo de la siguiente carta";

        public ApuestaAcertarPalo(Carta cartaOculta) : base(cartaOculta) { }

        private bool EsPalo(TipoPalo palo) => CartaOculta.EsPalo(palo);
        public bool EsOros() => CartaOculta.EsPalo(TipoPalo.Oros);
        public bool EsCopas() => CartaOculta.EsPalo(TipoPalo.Copas);
        public bool EsEspadas() => CartaOculta.EsPalo(TipoPalo.Espadas);
        public bool EsBastos() => CartaOculta.EsPalo(TipoPalo.Bastos);

        public override string Resultado() => CartaOculta.Palo.ToString();

       
        
    }
}
