using System;
using System.Threading.Tasks;
using Application.Interfaces;
using Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace TesteSuperDgt.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransferenciaController : Controller
    {
        private readonly IServicoTransferencia servicoTransferencia;

        public TransferenciaController(IServicoTransferencia servicoTransferencia)
        {
            this.servicoTransferencia = servicoTransferencia;
        }

        [HttpPost]
        public async Task<IActionResult> RealizarTransferencia([FromBody]RealizarTransferenciaViewModel dadostransferencia)
        {
            servicoTransferencia.RealizarTransferenciaAsync(dadostransferencia);
            return Ok();
        }
        
    }
}