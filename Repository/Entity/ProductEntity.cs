using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Repository.Entity
{
    public class ProductEntity
    {
        [Key]
        public int ID { get; set; }
        public string ProductName { get; set; }

        public int FK_Category { get; set; }
    }
}
