using System.Collections.Generic;

namespace GestaoDeFrota.Domain.Entities
{
    public class Combustivel : EntityBase
    {
        public string Nome { get; private set; }
        public virtual ICollection<Veiculo> Veiculos { get; private set; }

        public Combustivel(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
