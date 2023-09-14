
using Common;
using Repository;
using Repository.Entity;

namespace API.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }


		public void AddCategory(CategoriaModel model)
        {
            CategoryEntity entity = new CategoryEntity()
            {
                CategoryName = model.CategoryName
            };

            _categoryRepository.Add(entity);

        }

        public void UpdateCategory(CategoriaModel model)
        {
            CategoryEntity entity = new CategoryEntity()
            {
                CategoryName = model.CategoryName
            };
            _categoryRepository.Update(entity);
		
		}




        public IList<CategoryEntity> GetCategory()
		{
            return _categoryRepository.GetCategory().ToList();

		}



	}
}
