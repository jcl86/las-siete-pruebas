namespace SietePruebas.Core.Model
{
    public interface IMazo
    {
        int NumCartas { get; }

        Carta Robar();
    }
}