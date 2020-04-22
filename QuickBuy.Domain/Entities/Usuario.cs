namespace QuickBuy.Domain.Entities
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }

        public string eMail { get; set; }

        public string Nome { get; set; }

        public string SobreNome { get; set; }

        public string Senha { get; set; }

        public override void Validate()
        {
            if (Id == 0)
            {
                AdicionarCritica("Crítica: O usuário não foi identificado!");
            }

            if (string.IsNullOrEmpty(eMail))
            {
                AdicionarCritica("Crítica: O e-mail do usuário não foi informado!");
            }

            if (string.IsNullOrEmpty(Nome))
            {
                AdicionarCritica("Crítica: O Nome do usuário está em branco!");
            }

            if (string.IsNullOrEmpty(SobreNome))
            {
                AdicionarCritica("Crítica: O sobrenome do usuário está em branco!");
            }

            if (string.IsNullOrEmpty(Senha))
            {
                AdicionarCritica("Crítica: A senha do usuário não foi informada!");
            }
        }
    }
}
