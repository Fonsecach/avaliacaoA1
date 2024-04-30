using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFolha.Models
{
    public class Funcionario
    {
        [Key]
        public int? Id { get; set; }
        public string? Nome { get; set; }
        public string? Cpf { get; set; }

        public Funcionario()
        {

        }
        public Funcionario(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }
    }

}