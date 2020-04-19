using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Domain.Entities
{
    public abstract class Entidade
    {
        private List<string> MensagensValidacao { get; set; }

        public List<string> MensagemValidacao => MensagensValidacao ?? (MensagensValidacao = new List<string>());

        protected void LimparMensagensValidacao()
        {
            MensagensValidacao.Clear();
        }

        protected void AdicionarCritica(string mensagem)
        {
            MensagensValidacao.Add(mensagem);
        }

        public abstract void Validate();

        protected bool EhValido => !MensagemValidacao.Any();
    }
}
