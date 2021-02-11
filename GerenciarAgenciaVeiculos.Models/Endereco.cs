using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GerenciarAgenciaVeiculos.Models
{
    public class Endereco
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(7)]
        [Display(Name = "Tipo de endereço")]
        public string TipoEndereco { get; set; }

        [MaxLength(200)]
        [Display(Name = "Logradouro")]
        public string Logradouro { get; set; }

        [MaxLength(50)]
        [Display(Name = "Bairro")]
        public string Bairro { get; set; }

        [MaxLength(9)]
        [Display(Name = "CEP")]
        public string Cep { get; set; }

        [MaxLength(20)]
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }

        [MaxLength(2)]
        [Display(Name = "UF")]
        public string Uf { get; set; }

    }
}
