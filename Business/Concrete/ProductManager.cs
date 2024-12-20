using Business.Abstract;
using Core.DataAccess.Abstract;
using Core.Helpers.Results.Abstract;
using Core.Helpers.Results.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EF;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

    public class ProductManager(IProductDal productDal) : IProductService
    {
        private readonly IProductDal _productDal = productDal;
        public IResult Add(Product product)
        {
            if (product.ProductName.Length > 5)
            {
                _productDal.Add(product);
                return new SuccessResult("product elave olundur");

             }
            else
            {
            return new ErrorResult("length sehvdir");
            }
    }

    public IResult Delete(Product product)
        {
           Product deleteProduct = null;
            Product resultProduct= _productDal.GetAll().SingleOrDefault(p => p.Id == product.Id);
            if (resultProduct != null)
            {
            deleteProduct = resultProduct;
                _productDal.Delete(deleteProduct);
            }
            return new SuccessResult();
        }

        public IDataResult<List<Product>> GetAllProducts()
        {
           var products = _productDal.GetAll(p => p.IsDeleted == false);
        if (products.Count > 0)
        {
            return new SuccessDataResult<List<Product>>(products,"hamisi geldi");
        }
        else
        {
            return new ErrorDataResult<List<Product>>(products);
        }
        }

        public IDataResult<Product> GetProduct(Product product)
        {
            Product getProduct= _productDal.Get(p => p.Id == product.Id);
               return new SuccessDataResult<Product>(getProduct);

        }

        public IResult Update(Product product)
        {
            Product updateProduct = _productDal.Get(p => p.Id == product.Id&& product.IsDeleted==false);
            updateProduct.ProductName =product.ProductName;
            updateProduct.ProductDesc=product.ProductDesc; 
            updateProduct.ProductPrice= product.ProductPrice;
            updateProduct.ProductCount= product.ProductCount;
            _productDal.Update(updateProduct);
             return new SuccessResult();
        }


}