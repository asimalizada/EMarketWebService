using Core.DataAccess.Concrete.EntityFramework;
using EMarketWebService.DataAccess.Abstract;
using EMarketWebService.Entities.Concretes;

namespace EMarketWebService.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, EMarketContext>, ICategoryDal
    {
    }
}
