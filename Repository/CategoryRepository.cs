using Microsoft.EntityFrameworkCore;
using Repository.Context;
using Repository.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        protected EFContext _dataContext;

        public CategoryRepository(EFContext dataContext)
        {
            _dataContext = dataContext;

        }

        public void Add(CategoryEntity entity)
        {
            _dataContext.Add(entity);
            _dataContext.SaveChanges();

        }



        public void Update(CategoryEntity entity)
        {
            _dataContext.Update(entity);
            _dataContext.SaveChanges();
        }
   


        public IList<CategoryEntity> GetCategory()
        {
            return _dataContext.Category.ToList();

        }


    }
} 
