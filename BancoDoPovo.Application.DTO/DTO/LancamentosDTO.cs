namespace BancoDoPovo.Application.DTO.DTO
{
    public class LancamentosDTO
    {
        public int? Id { get; set; }
        public int ContaOrigem { get; set; }
        public int ContaDestino { get; set; }
        public string Operacao { get; set; }
        public decimal Valor { get; set; }
    }
}
