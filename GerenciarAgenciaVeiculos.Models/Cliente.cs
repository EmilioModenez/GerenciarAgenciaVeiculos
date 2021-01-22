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
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }

        public ICollection<Endereco> Enderecos { get; set; }
        public ICollection<Telefone> Telefones { get; set; }
    }
}
