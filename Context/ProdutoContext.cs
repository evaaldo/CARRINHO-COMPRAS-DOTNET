using CarrinhoCompras.Model;
using Microsoft.EntityFrameworkCore;

namespace CarrinhoCompras.Context
{
    public class ProdutoContext : DbContext
    {
        public ProdutoContext(DbContextOptions<ProdutoContext> options) : base(options)
        {

        }

        public DbSet<Produto> Produtos { get; set; }
    }
}