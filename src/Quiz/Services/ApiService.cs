using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Quiz.Domain;

namespace Quiz.Services
{
    public class ApiService
    {
        private List<Questao>? questoes = [];

        private HttpClient httpClient = new()
        {
            BaseAddress = new Uri("https://quiz.em3soft.com.br")
        };

        public async Task ObterQuestoesAsync()
        {
            var response = await httpClient.GetAsync("/questao/questoes");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();

            questoes = JsonSerializer.Deserialize<List<Questao>> (content);
            }
        }
    } 

}
