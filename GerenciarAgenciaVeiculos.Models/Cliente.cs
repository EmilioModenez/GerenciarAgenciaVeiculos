using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GerenciarAgenciaVeiculos.Models
{
    public class Cliente
    {
        public Cliente()
        {
            this.Enderecos = new List<Endereco>();
            this.Telefones = new List<Telefone>();
        }
        [Key]
        public int Id { get; set; }

        [MaxLength(200)]
        [Display(Name = "Nome")]
        [DataType(DataType.Text)]
        public string Nome { get; set; }

        [MaxLength(14)]
        [Display(Name = "CPF")]
        public string Cpf { get; set; }

        [MaxLength(10)]
        [Display(Name = "RG")]
        public string Rg { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        public ICollection<Endereco> Enderecos { get; set; }
        public ICollection<Telefone> Telefones { get; set; }
    }
}
