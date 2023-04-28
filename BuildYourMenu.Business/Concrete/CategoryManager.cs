using BuildYourMenu.Business.Abstract;
using BuildYourMenu.DataAccess.Abstract;
using BuildYourMenu.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildYourMenu.Business.Concrete
{
    public class CategoryManager:ICategoryService
    {
        private ICategoryDal _categoryDal;

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

      
        public CategoryManager(ICategoryDal categoryDal) 
        {
            _categoryDal = categoryDal;
        }
    }
}
