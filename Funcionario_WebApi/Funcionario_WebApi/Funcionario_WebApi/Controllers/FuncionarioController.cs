using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Funcionario_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {


        [HttpGet]
        public ActionResult Get() 
        {
            return Ok();
        }
    }
}
