using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService //Service olarak değiştirmek===-???
    {
        ICategoryDal _categoryDal;
        //EfCategoryRepository efCategoryRepository;
        //public CategoryManager()
        //{
        //    efCategoryRepository = new EfCategoryRepository();
        //}

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void CategoryAdd(Category category)
        {
            _categoryDal.insert(category);
        }

        public void CategoryDelete(Category category)
        {
            _categoryDal.delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _categoryDal.update(category);
        }

        public Category GetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public List<Category> GetList()
        {
            return _categoryDal.GetListAll();
        }
    }
}
