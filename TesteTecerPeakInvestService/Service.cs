using TesteTecerPeakInvestServiceDomain;
using TesteTecerPeakInvestServiceDomain.Interface;

namespace TesteTecerPeakInvestService
{
    public class Service : IService
    {
        private IRepository _repository;
        public Service(IRepository repository)
        {
            this._repository = repository;
        }

        public RetornoCalculoDomain Calculo(CalculoItemDomain calculoItem)
        {

            CalculoDomain calculo = new CalculoDomain(calculoItem);
            var validar = calculo.ValidaEntrada();

            if (!string.IsNullOrEmpty(validar))
                return new RetornoCalculoDomain(sucesso: false, mensagem: validar);

            var retornoCalculo = calculo.Calcular();

            return new RetornoCalculoDomain(sucesso: true, valorRetorno: retornoCalculo);

        }

        public RetornoConsultaDomain Consultar(int id)
        {
            var pessoa = this._repository.Consultar(id);
            if (pessoa != null)
                return new RetornoConsultaDomain(sucesso: true, pessoa: pessoa);

            return new RetornoConsultaDomain(sucesso: false, mensagem: "Pessoa não encotrada");
        }

       
    }
}
