using System;
using System.Collections.Generic;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using EMarketWebService.Business.Abstract;
using EMarketWebService.DataAccess.Abstract;
using EMarketWebService.Entities.Concretes;

namespace EMarketWebService.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IResult Add(Product product)
        {
            if (product.ProductName.Length < 3)
            {
                return new ErrorResult("Product name must be at least 3 letters.");
            }
            _productDal.Add(product);
            return new SuccessResult("Product added successfully!");
        }

        public IResult Update(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult("Product updated successfully!");
        }

        public IResult Delete(Product product)
        {
            _productDal.Delete(product);
            return new SuccessResult("Product deleted successfully!");
        }

        public IDataResult<List<Product>> GetAll()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll());
        }

        public IDataResult<Product> GetById(int id)
        {
            return new SuccessDataResult<Product>
                (_productDal.Get(p => p.Id == id));
        }
    }
}
