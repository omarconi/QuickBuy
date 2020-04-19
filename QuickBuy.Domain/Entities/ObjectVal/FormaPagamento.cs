using QuickBuy.Domain.Entities.Enums;

namespace QuickBuy.Domain.Entities.ObjectVal
{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public bool EhBoleto => Id == (int)TipoFormaPagamentoEnum.Boleto;
        public bool EhCartaoCredito => Id == (int)TipoFormaPagamentoEnum.CartaoCredito;
        public bool EhDeposito => Id == (int)TipoFormaPagamentoEnum.Deposito;
        public bool EhNaoDefinido => Id == (int)TipoFormaPagamentoEnum.NaoDefinido;
    }
}
