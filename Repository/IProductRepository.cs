using Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IProductRepository
    {
        public void Add(ProductEntity entity);
        public IList<ProductEntity> GetProduct();

	}
}
