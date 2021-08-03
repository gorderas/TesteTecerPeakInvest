using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteTecerPeakInvestWeb.ViewModel
{
    public abstract class ResponseBase
    {
        public bool Sucesso { get; set; }
        public string Mensagem { get; set; }
    }
}
