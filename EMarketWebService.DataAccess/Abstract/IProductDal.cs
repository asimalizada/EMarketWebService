using System.Collections.Generic;
using Core.DataAccess.Abstract;
using EMarketWebService.Entities.Concretes;
using EMarketWebService.Entities.Dtos;

namespace EMarketWebService.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductDetailsDto> GetProductDetails();
    }
}
