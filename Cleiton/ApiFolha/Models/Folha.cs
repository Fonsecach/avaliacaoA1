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

        public string? Valor { get; set; }

        public string? Quantidade { get; set; }

        public string? Mes { get; set; }

        public string? Ano { get; set; }

        public int? FuncionarioId { get; set; }

        [ForeignKey("FuncionarioId")]
        public Funcionario? Funcionario { get; set; }

        public Folha(string valor)
        {
            Valor = valor;
        }

        public Folha(string valor, string quantidade, string mes, string ano, int funcionarioId)
        {
            Valor = valor;
            Quantidade = quantidade;
            Mes = mes;
            Ano = ano;
            FuncionarioId = funcionarioId;
        }
    }
}
