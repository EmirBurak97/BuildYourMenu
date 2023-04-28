using BuildYourMenu.Business.Abstract;
using BuildYourMenu.DataAccess.Abstract;
using BuildYourMenu.Entities.ComplexTypes;
using BuildYourMenu.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildYourMenu.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }


        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<ProductDetails> GetProductDetails()
        {
            return  _productDal.GetProductDetails();
        }

        public List<Product> GetProductsByCategory(int categoryId)
        {
            return _productDal.GetAll(p=>p.CategoryId == categoryId);
        }

        public List<Product> GetProductsByName(string productName)
        {
            return _productDal.GetAll(p => p.ProductName.Contains(productName));
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
