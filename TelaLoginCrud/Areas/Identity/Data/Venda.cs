using System.ComponentModel.DataAnnotations;

namespace TelaLoginCrud.Areas.Identity.Data
{
    public class Venda
    {
        [Key]
        public int IdVenda { get; set; }
        public string Produto {  get; set; }
        public int qnt { get; set;}
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
    }
}
