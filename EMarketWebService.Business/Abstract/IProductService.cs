using System.Collections.Generic;
using Core.Utilities.Results.Abstract;
using EMarketWebService.Entities.Concretes;

namespace EMarketWebService.Business.Abstract
{
    public interface IProductService
    {
        IResult Add(Product product);
        IResult Update(Product product);
        IResult Delete(Product product);
        IDataResult<List<Product>> GetAll();
        IDataResult<Product> GetById(int id);
    }
}
