using Microsoft.AspNetCore.Mvc;
using mrdog_api.Data;
using Microsoft.EntityFrameworkCore;
namespace mrdog_api.Controllers;


[Route("api/[Controller]")]
[ApiController]

public class ProductoController:ControllerBase
{
    private readonly AppDBContext _productoRepository;

    public ProductoController(AppDBContext productoRepository)
    {
        _productoRepository = productoRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllProducts()
    {
        return Ok(await _productoRepository.Productos.ToListAsync());
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetProductDetails(long id)
    {
        return Ok(await _productoRepository.Productos.FindAsync(id));
    }
}