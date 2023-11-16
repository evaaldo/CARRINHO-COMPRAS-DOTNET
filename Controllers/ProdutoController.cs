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

        [HttpGet("{id}")]
        public async Task<ActionResult<Produto>> GerProdutos(int id)
        {
            if(_context.Produtos == null)
            {
                return NotFound();
            }

            var produto = await _context.Produtos.FindAsync(id);

            if(produto == null)
            {
                return NotFound();
            }

            return produto;
        }

        [HttpPost]
        public async Task<ActionResult<Produto>> PostProduto(Produto produto)
        {
            if(_context.Produtos == null)
            {
                return Problem("Construtor vazio!");
            }

            _context.Produtos.Add(produto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProdutos", new { id = produto.ID }, produto);
        }
        
    }
}