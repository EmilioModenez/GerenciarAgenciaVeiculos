using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GerenciarAgenciaVeiculos.Models
{
    public class Telefone
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(10)]
        public string Tipo { get; set; }

        [MaxLength(2)]
        [Display(Name = "DDD")]
        public string DDD { get; set; }

        [Display(Name = "Número")]
        [DataType(DataType.PhoneNumber)]
        public string NumeroTelefone { get; set; }

    }
}
