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
    public class UserManager:IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal= userDal;
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        

        public List<User> GetAll()
        {
            return _userDal.GetAll();
        }

        public User Get(string username,string pass) 
        {
            return _userDal.Get(p=>p.UserName==username && p.UserPass==pass);
        }

        
    }
}
