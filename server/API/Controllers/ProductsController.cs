using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly DataContext _context;

    public ProductsController(DataContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<List<Product>>> GetProducts()
    {
        var products = await _context.Products!.ToListAsync();
        return Ok(products);
    }

    [HttpGet("{id:long}")]
    public async Task<ActionResult<Product>> GetProduct(long id)
    {
        return (await _context.Products!.FindAsync(id))!;
    }
}