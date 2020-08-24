using System;

namespace BancoDoPovo.Domain.Models
{
    public class Lancamentos : Base
    {
        public int ContaOrigem { get; set; }
        public int ContaDestino { get; set; }
        public string Operacao { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public virtual ContaCorrente Conta { get; set; }
    }
}
