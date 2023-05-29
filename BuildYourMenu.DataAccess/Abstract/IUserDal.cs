using BuildYourMenu.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BuildYourMenu.DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        
    }
}
