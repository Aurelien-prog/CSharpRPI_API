using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using ProjetAPI.Context;

namespace ProjetAPI.Controllers
{
    [Route("Api/[controller]")]
    [ApiController]    
    
    public class CarteController : ControllerBase 
    {
        private readonly ApplicationDbContext _context;

        public CarteController(ApplicationDbContext dbContext)
        {
            _context = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Carte>>> GetAll()
        {
            return  Ok(await _context.Cartes.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult<List<string>>> PostCarte([FromBody]Carte carte)
        {
            if (carte == null) 
            {
                return BadRequest();
            }
            await _context.Cartes.AddAsync(carte);
            await _context.SaveChangesAsync();

            return Ok("Carte créer !");
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteCarte([FromBody]string name)
        {
            if(name == null)
            {
                return BadRequest();
            }

            Carte? carte = _context.Cartes.FirstOrDefault(id => id.name == name);

            if (carte != null)
            {
                _context.Cartes.Remove(carte);
                await _context.SaveChangesAsync();
                return Ok("");
            }

            return BadRequest();
        }
        /*[HttpPut("{id:int}")]
        public async Task<ActionResult<Employee>> UpdateEmployee(int id, Employee employee)
        {
            try
            {
                if(id != employee.EmployeeId)
                {
                    return BadRequest("Employee ID mismatch");
                }

                var employeeToUpdate = await employeeRepository.GetEmployee(id);

                if(employeeToUpdate == null)
                {
                    return NotFound($"Employee with Id = {id} not found");
                }

                return await employeeRepository.UpdateEmployee(employee);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error updating data");
            }
        }*/

        // [HttpPut]
        // public async Task<ActionResult<List<string>>> EditCarte([FromBody]Carte idC)
        // {

        // }
    }
}