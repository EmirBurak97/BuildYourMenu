using BuildYourMenu.DataAccess.Abstract;
using BuildYourMenu.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BuildYourMenu.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, ExampleContext>, ICategoryDal
    {
       
    }
}
