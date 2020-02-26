namespace GestaoDeFrota.Domain.Entities
{
    public class Quilometragem : EntityBase
    {
        public float Atual { get; private set; }
        public float Anterior { get; private set; }

        public Quilometragem(float atual, float anterior)
        {
            Id = Id;
            Atual = atual;
            Anterior = anterior;
        }
    }
}
