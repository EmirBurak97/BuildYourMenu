using BuildYourMenu.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildYourMenu.DataAccess.Concrete.EntityFramework.Mapping
{
    public class UserMap:EntityTypeConfiguration<User>
    {
        public UserMap() 
        {
            ToTable(@"Users", @"dbo");
            HasKey(x => x.UserId);

            Property(x => x.UserId).HasColumnName("UserId");
            Property(x => x.UserName).HasColumnName("UserName");
            Property(x => x.UserPass).HasColumnName("UserPass");
            Property(x => x.UserMail).HasColumnName("UserMail");
        }
    }
}
