
namespace TesteTecerPeakInvestServiceDomain
{
    public class RetornoConsultaDomain: RetornoBaseDomain
    {
        public RetornoConsultaDomain(bool sucesso, PessoaDomain pessoa = null, string mensagem = "OK")
        {
            base.Mensagem = mensagem;
            base.Sucesso = sucesso;
            this.Pessoa = pessoa;
        }

        public PessoaDomain Pessoa { get; private set; }
    }
}
