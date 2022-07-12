using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
    {
        public void delete(Category t)
        {
            throw new NotImplementedException();
        }

        public void insert(Category t)
        {
            throw new NotImplementedException();
        }

        public void update(Category t)
        {
            throw new NotImplementedException();
        }

        Category IGenericDal<Category>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        List<Category> IGenericDal<Category>.GetListAll()
        {
            throw new NotImplementedException();
        }
    }
}
