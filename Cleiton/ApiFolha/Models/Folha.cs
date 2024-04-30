using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFolha.Models
{

    public class Folha
    {
        [Key]
        public int Id { get; set; }

        public int? Valor { get; set; }

        public int? Quantidade { get; set; }

        public int? Mes { get; set; }

        public int? Ano { get; set; }

        public int? FuncionarioId { get; set; }

        [ForeignKey("FuncionarioId")]
        public Funcionario? Funcionario { get; set; }

        public Folha()
        {

        }

        public Folha(int valor, int quantidade, int mes, int ano, int funcionarioId)
        {
            Valor = valor;
            Quantidade = quantidade;
            Mes = mes;
            Ano = ano;
            FuncionarioId = funcionarioId;
        }
    }
}
