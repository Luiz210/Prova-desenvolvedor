using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prova_desenvolvedor.Context;
using Prova_desenvolvedor.Models;


namespace Prova_desenvolvedor.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class AtivoController : Controller
    {
        private readonly AppDbContext _context;

        public AtivoController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ativo>>> GetAtivos()
        {
            return await _context.Ativos.ToListAsync();
        }

        [HttpGet("byCode")]
        public async Task<ActionResult<Ativo>> GetAtivoByCode(string code)
        {
            var ativo = await _context.Ativos.FirstOrDefaultAsync(a => a.Code == code);
            if (ativo == null)
            {
                return NotFound();
            }
            return ativo;
        }


        [HttpPost]
        public async Task<ActionResult<Ativo>> PostAtivo(Ativo ativo)
        {
            _context.Ativos.Add(ativo);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAtivos), new { id = ativo.Id }, ativo);
        }
       
    }
}
