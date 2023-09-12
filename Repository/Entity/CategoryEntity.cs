using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Entity
{
    public class CategoryEntity
    {
        [Key]
        public int ID { get; set; }
        public string CategoryName { get; set; }

    }
}
