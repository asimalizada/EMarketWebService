using Core.DataAccess.Abstract;
using EMarketWebService.Entities.Concretes;

namespace EMarketWebService.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
    }
}
