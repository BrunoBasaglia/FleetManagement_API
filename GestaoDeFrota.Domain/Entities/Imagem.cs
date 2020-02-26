namespace GestaoDeFrota.Domain.Entities
{
    public class Imagem : EntityBase
    {
        public string Arquivo { get; set; }
        public string Diretorio { get; private set; }
        public string Extensao { get; private set; }
        public virtual int VeiculoId { get; set; }
        public virtual Veiculo Veiculo { get; set; }

        public Imagem(int id, string arquivo, string diretorio, string extensao, int veiculoId)
        {
            Id = Id;
            Arquivo = arquivo;
            Diretorio = diretorio;
            Extensao = extensao;
            VeiculoId = veiculoId;
        }
    }
}
