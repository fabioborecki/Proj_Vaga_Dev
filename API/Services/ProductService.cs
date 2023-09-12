using Common;
using Repository;
using Repository.Entity;
using System.Security.Cryptography.X509Certificates;

namespace API.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public void AddProduct(ProdutoModel model)
        {
            ProductEntity entity = new ProductEntity()
            {
                ProductName = model.ProductName
            };

            _productRepository.Add(entity);
        }

		public IList<ProductEntity> GetProduct()
		{
			return _productRepository.GetProduct().ToList();

		}

	}
}
