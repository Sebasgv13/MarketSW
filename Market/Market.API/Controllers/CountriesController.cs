using Market.API.Data;
using Market.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Market.API.Controllers
{

    [ApiController]
    [Route("/api/countries")]
    public class CountriesController : ControllerBase
    {
        private readonly DataContext _context;

        public CountriesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> get()
        {
            return Ok(await _context.Countries.ToListAsync());
        }

        //get por parametro----id
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var country = await _context.Countries.FirstOrDefaultAsync(c => c.Id == id);
            if (country == null)
            {
                return NotFound();//404
            }
            else
            {
                return Ok(country);//200
            }

        }
        //INSERTAR REGISTROS
        [HttpPost]
        public async Task<ActionResult> Post(Country country)
        {
            _context.Add(country);
            await _context.SaveChangesAsync();
            return Ok(country);//200
        }
        [HttpPut]
        public async Task<ActionResult> Put(Country country)
        {
            _context.Update(country);
            await _context.SaveChangesAsync();
            return Ok(country);
        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var filaafectada = await _context.Countries.Where(c => c.Id == id).ExecuteDeleteAsync();
            if (filaafectada == 0)
            {
                return NotFound();//404

            }
            return NoContent();//204

        }




    }
}

