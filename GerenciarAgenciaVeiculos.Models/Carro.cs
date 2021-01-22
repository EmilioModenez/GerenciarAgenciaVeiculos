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
        public string Placa { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public string Combustivel { get; set; }
        public int AnoFabricacao { get; set; }

        public int AnoModelo { get; set; }

        public string QuantidadePortas { get; set; }
        public int CilindradaMotor { get; set; }
        public int MyProperty { get; set; }
    }
}
