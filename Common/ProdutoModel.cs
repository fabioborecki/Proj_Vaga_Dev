
using System.ComponentModel.DataAnnotations;

namespace Common
{
    public class ProdutoModel
    {
        [Key]
        public int ID { get; set; }
        public string ProductName { get; set; }

        public int FK_Category { get; set; }




    }
}
