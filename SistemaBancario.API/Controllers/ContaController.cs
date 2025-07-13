using Microsoft.AspNetCore.Mvc;
using SistemaBancario.Core.Services;

namespace SistemaBancario.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ContaController : ControllerBase
{
    private readonly ContaService _service;

    public ContaController(ContaService service)
    {
        _service = service;
    }


    [HttpGet("saldo")]
    public IActionResult ConsultarSaldo()
    {
        var saldo = _service.ConsultarSaldo();
        return Ok(saldo);
    }

    [HttpPost("depositar")]
    public IActionResult Depositar([FromBody] decimal valor)
    {
        _service.Depositar(valor);
        return Ok("Depósito realizado.");
    }

    [HttpPost("sacar")]
    public IActionResult Sacar([FromBody] decimal valor)
    {
        try
        {
            _service.Sacar(valor);
            return Ok("Saque realizado.");
        }
        catch (InvalidOperationException e)
        {
            return BadRequest(e.Message);
        }
    }
}
