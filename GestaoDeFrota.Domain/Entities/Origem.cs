using System.Collections.Generic;

namespace GestaoDeFrota.Domain.Entities
{
    public class Origem : EntityBase
    {
        public string Procedencia { get; private set; }
        public virtual ICollection<Veiculo> Veiculos { get; private set; }

        public Origem(int id, string procedencia)
        {
            Id = id;
            Procedencia = procedencia;
        }
    }
}
