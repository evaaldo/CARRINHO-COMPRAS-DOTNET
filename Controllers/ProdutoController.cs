using CarrinhoCompras.Context;
using CarrinhoCompras.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarrinhoCompras.Controller
{
    [Route("CarinhoCompras")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly ProdutoContext? _context;

        public ProdutoController(ProdutoContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Produto>>> GetProdutos()
        {
            if(_context.Produtos == null)
            {
                return NotFound();
            }

            return await _context.Produtos.ToListAsync();
        }
    }
}