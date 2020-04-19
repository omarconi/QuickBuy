﻿namespace QuickBuy.Domain.Entities
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }

        public int ProdutoId { get; set; }

        public int Quantidade { get; set; }

        public override void Validate()
        {
            if (ProdutoId == 0)
            {
                AdicionarCritica("Crítica: O produto não foi identificado!");
            }

            if (Quantidade == 0)
            {
                AdicionarCritica("Crítica: A quantidade do produto não foi informada!");
            }
        }
    }
}
