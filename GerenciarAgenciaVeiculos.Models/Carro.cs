using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciarAgenciaVeiculos.Models
{
    public class Carro
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(4)]
        [Range(1900, 2100)]
        [Display(Name = "Ano Modelo")]
        public int AnoModelo { get; set; }

        [MaxLength(4)]
        [Range(1900, 2100)]
        [Display(Name = "Ano de fabricação")]
        public int AnoFabricacao { get; set; }

        [MaxLength(9)]
        [Display(Name = "Placa")]
        public string Placa { get; set; }

        [Display(Name = "Chassi")]
        public string Chassi { get; set; }

        [Display(Name = "Marca")]
        public string Marca { get; set; }

        [Display(Name = "Modelo")]
        public string Modelo { get; set; }

        [Display(Name = "Combustível")]
        public string Combustivel { get; set; }

        [Range(1, 10)]
        [Display(Name = "Qtde de portas")]
        public int QuantidadePortas { get; set; }

        [Range(1, 10000)]
        [Display(Name = "Cilindradas do motor")]
        public int CilindradaMotor { get; set; }
    }
}
