using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PostCodeBrazil.Integration.Interface;
using PostCodeBrazil.Integration.Response;
using Refit;

namespace PostCodeBrazil.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostCodeController : ControllerBase
    {

        private readonly IViaCepIntegration _viaCepIntegration;

        public PostCodeController(IViaCepIntegration viaCepIntegration)
        {
            _viaCepIntegration = viaCepIntegration;
        }


        [HttpGet("{cep}")]
        public async Task<ActionResult<PostCodeResponse>> GetPostCode(string cep)
        {
           var response = await _viaCepIntegration.GetDataFromViaCep(cep);
           if(response == null){
            return BadRequest("PostCode Not Found!");
           }

           return Ok(response);
        }
    }
}