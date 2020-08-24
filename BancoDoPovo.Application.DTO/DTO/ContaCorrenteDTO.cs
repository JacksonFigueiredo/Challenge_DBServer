namespace BancoDoPovo.Application.DTO.DTO
{
    public class ContaCorrenteDTO
    {
        public int? Id { get; set; }
        public string NomeCorrentista { get; set; }
        public int Agencia { get; set; }
        public int NumeroContaCorrente { get; set; }
        public int Digito { get; set; }
        public decimal Saldo { get; set; }
    }
}
