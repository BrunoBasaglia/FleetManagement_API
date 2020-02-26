using System.Collections.Generic;

namespace GestaoDeFrota.Domain.Entities
{
    public class Motor : EntityBase
    {
        public string Motorizacao { get; private set; }
        public virtual ICollection<Veiculo> Veiculos { get; private set; }

        public Motor(int id, string motorizacao)
        {
            Id = id;
            Motorizacao = motorizacao;
        }
    }
}
