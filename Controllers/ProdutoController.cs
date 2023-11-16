using CarrinhoCompras.Context;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace CarrinhoCompras.Controller
{
    [Route("CarrinhoCompras")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly ProdutoContext? _context;

        public ProdutoController(ProdutoContext context)
        {
            _context = context;
        }
    }
}