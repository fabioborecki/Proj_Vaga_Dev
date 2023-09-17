using Common;
using Repository.Entity;

namespace API.Services
{
    public interface IProductService
    {
        public void AddProduct(ProdutoModel model);

        public void Remove(ProdutoModel model);
        public IList<ProductEntity> GetProduct();

	}
}
