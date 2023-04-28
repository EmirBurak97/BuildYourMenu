using BuildYourMenu.Entities.ComplexTypes;
using BuildYourMenu.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildYourMenu.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetails> GetProductDetails();
    }
}
