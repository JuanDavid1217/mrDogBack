using Microsoft.AspNetCore.Mvc;
using mrdog_api.Data;
using Microsoft.EntityFrameworkCore;

namespace mrdog_api.Controllers;


[Route("api/[Controller]")]
[ApiController]

public class CategoriaController:ControllerBase
{
    private readonly AppDBContext _categoriaRepository;

    public CategoriaController(AppDBContext categoriaRepository)
    {
        _categoriaRepository = categoriaRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllProducts()
    {
        return Ok(await _categoriaRepository.Categorias.ToListAsync());
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetProductDetails(int id)
    {
        return Ok(await _categoriaRepository.Categorias.FindAsync(id));
    }
}