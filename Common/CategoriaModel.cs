
using System.ComponentModel.DataAnnotations;

namespace Common
{
    public class CategoriaModel
    {
        [Key]
        public int ID { get; set; }
        public string CategoryName { get; set; }
   
    }
}
