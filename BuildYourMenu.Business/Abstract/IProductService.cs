using BuildYourMenu.Entities.ComplexTypes;
using BuildYourMenu.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildYourMenu.Business.Abstract
{
    public interface IProductService
    {
        void Add(Product product);
        void Delete(Product product);
        List<Product> GetAll();
        List<ProductDetails> GetProductDetails();
        List<Product> GetProductsByCategory(int categoryId);
        List<Product> GetProductsByName(string productName);
        void Update(Product product);
    }
}
