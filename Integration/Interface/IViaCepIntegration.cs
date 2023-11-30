using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PostCodeBrazil.Integration.Response;

namespace PostCodeBrazil.Integration.Interface
{
    public interface IViaCepIntegration
    {
        Task<PostCodeResponse> GetDataFromViaCep(string cep);
        
    }
}