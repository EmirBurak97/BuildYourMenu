using BuildYourMenu.DataAccess.Abstract;
using BuildYourMenu.Entities.Abstract;
using BuildYourMenu.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BuildYourMenu.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, ExampleContext>, IUserDal
    {
    }
}
