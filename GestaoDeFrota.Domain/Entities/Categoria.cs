using System.Collections.Generic;

namespace GestaoDeFrota.Domain.Entities
{
    public class Categoria : EntityBase
    {
        public string Tipo { get; private set; }
        public virtual ICollection<Veiculo> Veiculos { get; private set; }

        public Categoria(int id, string tipo)
        {
            Id = id;
            Tipo = tipo;
        }
    }
}
