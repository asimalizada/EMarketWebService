
using Core.Entities.Abstract;

namespace EMarketWebService.Entities.Concretes
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
