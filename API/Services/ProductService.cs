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
                ProductName = model.ProductName,
                FK_Category = model.FK_Category
            };

            _productRepository.Add(entity);
        }

        public void Remove(ProdutoModel model)
        {
            ProductEntity entity = new ProductEntity() {
                ID = model.ID 
            };
            _productRepository.Remove(entity);
            
        }

        public IList<ProductEntity> GetProduct()
		{
			return _productRepository.GetProduct().ToList();

		}

	}
}
