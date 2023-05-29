using BuildYourMenu.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildYourMenu.Business.Abstract
{
    public interface IUserService
    {
        void Add(User user);
        User Get(string username, string pass);
        List<User> GetAll();

        
        
    }
}
