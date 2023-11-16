using System.ComponentModel.DataAnnotations;

namespace CarrinhoCompras.Model
{
    public class Produto
    {
        [Required]
        public Guid ID { get; set; }
        [Required]
        public string Nome { get; set; } = string.Empty;
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Validade { get; set; }
    }
}