using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PostCodeBrazil.Integration.Response;
using Refit;

namespace PostCodeBrazil.Integration.Refit
{
    public interface IViaCepIntegrationRefit
    {

        [Get("/ws/{postCode}/json")]
        Task<ApiResponse<PostCodeResponse>> getDataByPostCode(string postCode);
    }
}