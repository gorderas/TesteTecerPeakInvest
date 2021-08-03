using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteTecerPeakInvestServiceDomain;
using TesteTecerPeakInvestServiceDomain.Interface;

namespace TesteTecerPeakInvestRepository
{
    public class Repository : IRepository
    {
        public PessoaDomain Consultar(int id)
        {
            return this.MocPessoas().Where(x => x.Id == id).FirstOrDefault();
            
        }

        private ICollection<PessoaDomain> MocPessoas()
        {
            var retorno = new List<PessoaDomain>();
            retorno.Add(new PessoaDomain(1, "João"));
            retorno.Add(new PessoaDomain(2, "Maria"));
            retorno.Add(new PessoaDomain(3, "Daniel"));
            retorno.Add(new PessoaDomain(4, "Carlos"));

            return retorno;

        }
    }
}
