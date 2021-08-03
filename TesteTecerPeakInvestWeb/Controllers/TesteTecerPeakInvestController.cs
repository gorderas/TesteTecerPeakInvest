using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteTecerPeakInvestWeb.Models;
using TesteTecerPeakInvestWeb.ViewModel;

namespace TesteTecerPeakInvestWeb.Controllers
{
    public class TesteTecerPeakInvestController : Controller
    {
        // GET: TesteTecerPeakInvestController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ResultadoCadastro(Retorno retorno)
        {

            return View(retorno);
        }

        public ActionResult Cadastro()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Cadastro(RequestCadastro request)
        {
            Retorno retorno = new Retorno();
            try
            {
                TesteTecerPeakInvestModel model = new TesteTecerPeakInvestModel();
                retorno = model.Cadastrar(request);

                return RedirectToAction(nameof(ResultadoCadastro), retorno);
            }
            catch(Exception ex)
            {
                retorno.Sucesso = false;
                retorno.ValorRetorno = $"Erro: {ex.Message}";
                return RedirectToAction(nameof(ResultadoCadastro), retorno);
            }
        }

        [HttpPost]
        public ActionResult Consultar(RequestConsulta request)
        {
            Retorno retorno = new Retorno();
            try
            {
                TesteTecerPeakInvestModel model = new TesteTecerPeakInvestModel();
                retorno = model.Consulta(request);

                return RedirectToAction(nameof(ResutadoConsulta), retorno);
            }
            catch (Exception ex)
            {
                retorno.Sucesso = false;
                retorno.ValorRetorno = $"Erro: {ex.Message}";
                return RedirectToAction(nameof(ResutadoConsulta), retorno);
            }

            
        }

        public ActionResult Consultar()
        {
            return View();
        }

        public ActionResult ResutadoConsulta(Retorno retorno)
        {
            return View(retorno);
        }





    }
}
