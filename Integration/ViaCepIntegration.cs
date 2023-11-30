using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PostCodeBrazil.Integration.Interface;
using PostCodeBrazil.Integration.Refit;
using PostCodeBrazil.Integration.Response;

namespace PostCodeBrazil.Integration
{
    public class ViaCepIntegration : IViaCepIntegration
    {

        private readonly IViaCepIntegrationRefit _viacepIntegration;

        public ViaCepIntegration(IViaCepIntegrationRefit viaCepIntegrationRefit)
        {

            _viacepIntegration = viaCepIntegrationRefit;

        }

        public async Task<PostCodeResponse> GetDataFromViaCep(string cep)
        {
            var responseData = await _viacepIntegration.getDataByPostCode(cep);

            if (responseData != null && responseData.IsSuccessStatusCode)
            {
                return responseData.Content;
            }

            return null;



        }
    }
}