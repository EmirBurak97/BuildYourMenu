using BuildYourMenu.DataAccess.Abstract;
using BuildYourMenu.Entities.ComplexTypes;
using BuildYourMenu.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BuildYourMenu.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, ExampleContext>, IProductDal
    {
        public List<ProductDetails> GetProductDetails()
        {
            using (ExampleContext context= new ExampleContext())
            {
                var result = from p in context.Products
                             join c in context.Categories on p.CategoryId equals c.CategoryId
                             select new ProductDetails 
                             {
                                 ProductId = p.ProductId, 
                                 ProductName = p.ProductName, 
                                 CategoryName=c.CategoryName,
                                 UnitPrice=p.UnitPrice 
                             };
                return result.ToList();
            }
        }
    }
}
