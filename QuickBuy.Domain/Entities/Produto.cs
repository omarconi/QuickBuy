namespace QuickBuy.Domain.Entities
{
    public class Produto: Entidade
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public decimal Preco { get; set; }

        public override void Validate()
        {
            if (Id == 0)
            {
                AdicionarCritica("Crítica: O Produto precisa de um ID!");
            }

            if (string.IsNullOrEmpty(Nome))
            {
                AdicionarCritica("Crítica: O produto está sem Nome!");
            }

            if (string.IsNullOrEmpty(Descricao))
            {
                AdicionarCritica("Crítica: O produto está sem descrição!");
            }

            if (Preco == 0)
            {
                AdicionarCritica("Crítica: O produto está sem preço!");
            }
        }
    }
}
