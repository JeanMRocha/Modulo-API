using Microsoft.AspNetCore.Mvc;

namespace Modulo_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] 

	public class UsuarioController : ControllerBase
	{   
        [HttpGet("ObterDataHoraAtual")]
	   public IActionResult ObterDataHora()
       {
        var obj = new
        {
        Data = DateTime.Now.ToLongDateString(),
        Hora = DateTime.Now.ToLongTimeString()
        };
        return Ok(obj);
       }
               [HttpGet("ObterMensagem")]
	   public IActionResult Apresentar( string nome)
       {
        var mensagem = $"Olá {nome}, seja bem vindo!";
        return Ok(new{mensagem});
       }
	}
}