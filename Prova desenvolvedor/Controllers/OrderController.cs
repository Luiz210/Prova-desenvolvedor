using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prova_desenvolvedor.Context;
using Prova_desenvolvedor.Models;

namespace Prova_desenvolvedor.Controllers
{
    [Route("api/Order")]
    [ApiController]
    public class OrderController : Controller
    {
        private readonly AppDbContext _context;

        public OrderController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrders()
        {
            var orders = await _context.Orders.Include(o => o.Code).ToListAsync();

            foreach (var order in orders)
            {
                order.Date = order.Date.Date;
            }

            return orders;
        }


        [HttpPost("ByCode")]
        public async Task<ActionResult<Order>> PostOrderWithCodeAtivo(string code,[FromBody] Order order)
        {
            var ativo = await _context.Ativos.FirstOrDefaultAsync(a => a.Code == code);
            if (ativo == null)
            {
                return NotFound();
            }

            order.Code = ativo;

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetOrders), new { id = order.Id }, order);
        }


    }
}