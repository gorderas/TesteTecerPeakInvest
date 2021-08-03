using System;

namespace TesteTecerPeakInvestServiceDomain
{
    public class CalculoDomain
    {
        private const decimal _percentual = 5;
        private CalculoItemDomain _calculoItemDomain;

        public CalculoDomain(CalculoItemDomain calculoItemDomain)
        {
            this._calculoItemDomain = calculoItemDomain;
        }


        public decimal Calcular()
        {
            var subResultado = this._calculoItemDomain.Valor * this._calculoItemDomain.Parcelas;
            var resultado = subResultado + (subResultado * _percentual) / 100;

            return resultado;
        }

        public string ValidaEntrada()
        {
            if (this._calculoItemDomain.Valor <= 0 || this._calculoItemDomain.Parcelas <= 0)
                return "Numero de parcelas e o valor não podem ser menor ou igual Zero!";

            return string.Empty;
        }


    }
}
