using Microsoft.AspNetCore.Mvc;
using mrdog_api.Data;
using Microsoft.EntityFrameworkCore;

namespace mrdog_api.Controllers;


[Route("api/[Controller]")]
[ApiController]

public class TallasMascotaController:ControllerBase
{
    private readonly AppDBContext _tallaRepository;

    public TallasMascotaController(AppDBContext tallaRepository)
    {
        _tallaRepository = tallaRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllProducts()
    {
        return Ok(await _tallaRepository.Tallas_mascota.ToListAsync());
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetProductDetails(int id)
    {
        return Ok(await _tallaRepository.Tallas_mascota.FindAsync(id));
    }
}