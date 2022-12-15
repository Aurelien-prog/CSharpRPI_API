using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using ProjetAPI.Context;

namespace ProjetAPI.Controllers
{
    [Route("Api/[controller]")]
    [ApiController]

    public class TypeController : ControllerBase 
    {
        private readonly ApplicationDbContext _context;
        public TypeController(ApplicationDbContext dbContext)
        {
            _context = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Carte>>> Get()
        {
            return  Ok(await _context.Types.ToListAsync());
        }
    }
}