using System.Collections.Generic;

namespace GestaoDeFrota.Domain.Entities
{
    public class Modelo : EntityBase
    {
        public string Nome { get; private set; }
        public virtual ICollection<Veiculo> Veiculos { get; private set; }
        public virtual int FabricanteId { get; set; }
        public virtual Fabricante Fabricante { get; private set; }

        public Modelo(int id, string nome, int fabricanteId)
        {
            Id = id;
            Nome = nome;
            FabricanteId = fabricanteId;
        }
    }
}
