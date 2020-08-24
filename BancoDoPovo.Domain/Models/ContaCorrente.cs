using System;

namespace BancoDoPovo.Domain.Models
{
    public class ContaCorrente : Base
    {
        public string NomeCorrentista { get; set; }
        public int Agencia { get; set; }
        public int NumeroContaCorrente { get; set; }
        public int Digito { get; set; }
        public decimal Saldo { get; set; }

    }
}
