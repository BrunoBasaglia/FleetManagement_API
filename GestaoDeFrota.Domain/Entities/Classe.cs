using System.Collections.Generic;

namespace GestaoDeFrota.Domain.Entities
{
    public class Classe : EntityBase
    {
        public string Classificacao { get; private set; }
        public virtual ICollection<Veiculo> Veiculos { get; private set; }

        public Classe(int id, string classificacao)
        {
            Id = id;
            Classificacao = classificacao;
        }
    }
}
