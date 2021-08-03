using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;
using TesteTecerPeakInvestWeb.ViewModel;

namespace TesteTecerPeakInvestWeb.Models
{
    public class TesteTecerPeakInvestModel
    {
        const string urlApi = "https://localhost:44331/";


        public Retorno Cadastrar(RequestCadastro requestCadastro)
        {

            Retorno retorno = new Retorno();

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(urlApi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = client.PostAsJsonAsync("api/v1/teste/calculo", requestCadastro).Result;
                var resultado = response.Content.ReadFromJsonAsync<ResponseCalculo>().Result;

                if (response.IsSuccessStatusCode)
                {
                    retorno.Sucesso = resultado.Sucesso;
                    retorno.ValorRetorno = $"R$ {resultado.ValorRetorno.ToString("N3")}";
                }
                else
                {
                    retorno.Sucesso = resultado.Sucesso;
                    retorno.ValorRetorno = $"Erro: {resultado.Mensagem}";
                }


                return retorno;

            }
        }

        public Retorno Consulta(RequestConsulta request)
        {
            Retorno retorno = new Retorno();
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(urlApi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = client.GetAsync($"api/v1/teste/consulta?id={request.Id}").Result;
                var resultado = response.Content.ReadFromJsonAsync<ResponserConsulta>().Result;

                if (response.IsSuccessStatusCode)
                {
                    retorno.Sucesso = resultado.Sucesso;
                    retorno.ValorRetorno = $"Id: {resultado.Pessoa.Id}, Nome: {resultado.Pessoa.Nome}";
                   
                }
                else
                {
                    retorno.Sucesso = resultado.Sucesso;
                    retorno.ValorRetorno = $"Erro: {resultado.Mensagem}";
                }

                return retorno;



            }

        }
    }
}
