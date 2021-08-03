using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteTecerPeakInvestServiceDomain.Interface
{
    public interface IService 
    {
        public RetornoCalculoDomain Calculo(CalculoItemDomain calculoItem);
        public RetornoConsultaDomain Consultar(int id);
    }
}
