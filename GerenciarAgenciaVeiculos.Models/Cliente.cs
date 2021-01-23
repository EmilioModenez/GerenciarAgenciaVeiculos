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
            this.Enderecos = new Endereco();
            this.Telefones = new Telefone();
        }
        [Key]
        public int Id { get; set; }
        [Display(Name = "Nome")]
        [DataType(DataType.Text)]
        public string Nome { get; set; }
        [Display(Name = "CPF")]
        public string Cpf { get; set; }
        [Display(Name = "RG")]
        public string Rg { get; set; }
        [Display(Name ="Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        public Endereco Enderecos { get; set; }
        public Telefone Telefones { get; set; }
    }
}
