using QuickBuy.Domain.Entities.ObjectVal;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Domain.Entities
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }

        public int UsuarioId { get; set; }

        public DateTime DataPedido { get; set; }

        public DateTime DataPrevisaoEntrega { get; set; }

        public string CEP { get; set; }

        public string EnderecoCompleto { get; set; }

        public int NumeroEndereco { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public FormaPagamento FormaPagamento { get; set; }

        public int FormaPagamentoId { get; set; }

        /// <summary>
        /// Pedido deve ter pelo menos um item
        /// </summary>
        public ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validate()
        {

            LimparMensagensValidacao();

            if (!ItensPedido.Any())
                MensagemValidacao.Add("Crítica: Pedido precisa de pelo menos um item!");
            
            if (string.IsNullOrEmpty(CEP))
            {
                MensagemValidacao.Add("Crítica: CEP não informado!");
            }

        }
    }
}
