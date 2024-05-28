using Microsoft.AspNetCore.Mvc;
using mrdog_api.Data;
using Microsoft.EntityFrameworkCore;
namespace mrdog_api.Controllers;


[Route("api/[Controller]")]
[ApiController]

public class PaqueteController:ControllerBase
{
    private readonly AppDBContext _paqueteRepository;

    public PaqueteController(AppDBContext paqueteRepository)
    {
        _paqueteRepository = paqueteRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllProducts()
    {
        return Ok(await _paqueteRepository.Paquetes_estetica.ToListAsync());
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetProductDetails(int id)
    {
        return Ok(await _paqueteRepository.Paquetes_estetica.FindAsync(id));
    }
}