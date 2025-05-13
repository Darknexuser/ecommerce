using Ecommerce.Api.Data;
using System.Runtime.Serialization.DataContracts;
using Microsoft.AspNetCore.Mvc;
using Ecommerce.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Api.Controllers
{
    [ApiController]
    [Route("api/countries")]
    public class CountriesController : ControllerBase
    {

        private readonly DataContext _context;
        public CountriesController(DataContext context)
        {
            _context = context;

        }

        [HttpPut]
        public async Task<ActionResult> Put(country country)
        {
            _context.Update(country);

            await _context.SaveChangesAsync();

            return Ok(country);

        }


        [HttpDelete("{id:int}")]

        public async Task<ActionResult> Delete(int id)
        {
            var afectedRows= await _context.countries.Where(c => c.Id == id).ExecuteDeleteAsync();

            if (afectedRows == 0)
            {
                return NotFound();
            }

            return NoContent();

        }

        [HttpGet]
        public async Task<ActionResult> Get(int id)
        {
            return Ok(await _context.countries.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult> post(country country)
        {
            _context.Add(country);
            await _context.SaveChangesAsync();
            return Ok(country);
        }



    }





}
