using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using TesteTecerPeakInvestServiceDomain;
using TesteTecerPeakInvestServiceDomain.Interface;

namespace TesteTecerPeakInvest.Controllers
{
    [Route("api/v1/teste")]
    [ApiController]
    public class TesteController : ControllerBase
    {
        private IService _service;

        public TesteController(IService service)
        {
            this._service = service;
        }

        [Route("calculo"), HttpPost]
        public IActionResult Post([FromBody] CalculoItemDomain calculo)
        {
            try
            {
                var resultado = this._service.Calculo(calculo);

                if (resultado.Sucesso)
                    return StatusCode(StatusCodes.Status200OK, resultado);

                return StatusCode(StatusCodes.Status400BadRequest, resultado);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }

        [Route("consulta"), HttpGet]
        public IActionResult Get([FromQuery] int id)
        {

            try
            {

                var resultado = this._service.Consultar(id);

               if (!resultado.Sucesso)
                    return StatusCode(StatusCodes.Status404NotFound, resultado);

                return StatusCode(StatusCodes.Status200OK, resultado);

            }
            catch (Exception ex)
            {
                //Gravar Log
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao localizar registros");
            }


        }
    }
}
