using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestaoDeFrota.Domain.Entities
{
    public class Veiculo : EntityBase
    {
        public string Placa { get; private set; }
        public int Portas { get; private set; }
        public int Tanque { get; private set; }
        public string Chassi { get; private set; }
        public string Potencia { get; private set; }
        public int Lugares { get; private set; }
        public decimal Valor { get; private set; }
        public string Observacao { get; private set; }
        //Foreign Keys
        public int OrigemId { get; private set; }
        public int ClasseId { get; private set; }
        public int CategoriaId { get; private set; }
        public int CambioId { get; private set; }
        public int CombustivelId { get; private set; }
        public int ModeloId { get; private set; }
        public int MotorId { get; private set; }
        public double Quilometragem { get; set; }
        //Virtual Objects
        public virtual Origem Origem { get; set; }
        public virtual Classe Classe { get; private set; }
        public virtual Categoria Categoria { get; private set; }
        public virtual Cambio Cambio { get; set; }
        public virtual Combustivel Combustivel { get; private set; }
        public virtual Modelo Modelo { get; private set; }
        public virtual Motor Motor { get; private set; }
        public virtual Imagem Imagem { get; set; }
        //public Quilometragem Quilometragem { get; set; }

        [NotMapped]
        public IFormFile Img { get; set; }

        public Veiculo(int id, string placa, int portas, int tanque, string chassi, string potencia, int lugares, decimal valor, int origemId,
            int classeId, int categoriaId, int cambioId, int combustivelId, int modeloId, int motorId)
        {
            Id = id;
            Placa = placa;
            Portas = portas;
            Tanque = tanque;
            Chassi = chassi;
            Potencia = potencia;
            Lugares = lugares;
            Valor = valor;
            OrigemId = origemId;
            ClasseId = classeId;
            CategoriaId = categoriaId;
            CambioId = cambioId;
            CombustivelId = combustivelId;
            ModeloId = modeloId;
            MotorId = MotorId;
        }
    }
}
