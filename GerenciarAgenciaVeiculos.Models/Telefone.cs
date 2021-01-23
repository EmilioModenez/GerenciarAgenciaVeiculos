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
        public string Tipo { get; set; }
        public string DDD { get; set; }
        [Display(Name = "Telefone")]
        [DataType(DataType.PhoneNumber)]
        public string NumeroTelefone { get; set; }

    }
}
