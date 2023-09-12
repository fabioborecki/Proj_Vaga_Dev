using Common;
using Repository.Entity;

namespace API.Services
{
    public interface ICategoryService
    {

		public void AddCategory(CategoriaModel model);

        public void UpdateCategory(CategoriaModel model);

		public IList<CategoryEntity> GetCategory();

	}
}
