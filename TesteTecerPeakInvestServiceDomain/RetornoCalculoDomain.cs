
namespace TesteTecerPeakInvestServiceDomain
{
    public class RetornoCalculoDomain : RetornoBaseDomain
    {
        public RetornoCalculoDomain(bool sucesso, decimal valorRetorno = 0, string mensagem = "OK")
        {
            base.Mensagem = mensagem;
            base.Sucesso = sucesso;
            this.ValorRetorno = valorRetorno;
        }

        public decimal ValorRetorno { get; private set; }
    }
}