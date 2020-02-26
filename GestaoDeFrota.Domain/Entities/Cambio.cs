using System.Collections.Generic;

namespace GestaoDeFrota.Domain.Entities
{
    public class Cambio : EntityBase
    {
        public string Tipo { get; private set; }
        public virtual ICollection<Veiculo> Veiculos { get; private set; }

        public Cambio(int id, string tipo)
        {
            Id = id;
            Tipo = tipo;
        }
    }
}
