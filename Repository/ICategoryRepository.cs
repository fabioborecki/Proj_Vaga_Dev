using Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface ICategoryRepository
    {
	//	public void Category(CategoryEntity entity);
		public void Add(CategoryEntity entity);

        public void Update(CategoryEntity entity);

		public IList<CategoryEntity> GetCategory();
	}
}
