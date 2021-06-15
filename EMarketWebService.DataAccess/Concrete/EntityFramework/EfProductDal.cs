using System.Linq;
using System.Collections.Generic;
using Core.DataAccess.Concrete.EntityFramework;
using EMarketWebService.DataAccess.Abstract;
using EMarketWebService.Entities.Concretes;
using EMarketWebService.Entities.Dtos;

namespace EMarketWebService.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, EMarketContext>, IProductDal
    {
        public List<ProductDetailsDto> GetProductDetails()
        {
            using (EMarketContext context = new EMarketContext())
            {
                var result = from p in context.Products
                    join c in context.Categories on p.CategoryId equals c.Id
                    select new ProductDetailsDto
                    {
                        Id = p.Id,
                        ProductName = p.ProductName,
                        Price = p.Price,
                        UnitsInStock = p.UnitsInStock,
                        CategoryName = c.Name
                    };
                return result.ToList();
            }
        }
    }
}
