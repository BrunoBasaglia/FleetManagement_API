using System.Collections.Generic;

namespace GestaoDeFrota.Domain.Entities
{
    public class Fabricante : EntityBase
    {
        public string Nome { get; set; }
        public virtual ICollection<Modelo> Modelos { get; set; }

        public Fabricante(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
