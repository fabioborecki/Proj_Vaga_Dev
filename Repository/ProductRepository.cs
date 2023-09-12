using Repository.Context;
using Repository.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository 
{
    public class ProductRepository : IProductRepository
    {
        protected EFContext _productContext;

        public ProductRepository(EFContext productContext)
        {
            _productContext = productContext;

        }

        public void Add(ProductEntity entity)
        {
            _productContext.Add(entity);
            _productContext.SaveChanges();
            

        }

		public IList<ProductEntity> GetProduct()
		{
            return _productContext.Product.ToList();
              

		}
	}
}
