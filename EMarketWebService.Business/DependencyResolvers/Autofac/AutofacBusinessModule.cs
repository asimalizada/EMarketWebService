using Autofac;
using EMarketWebService.Business.Abstract;
using EMarketWebService.Business.Concrete;
using EMarketWebService.DataAccess.Abstract;
using EMarketWebService.DataAccess.Concrete.EntityFramework;

namespace EMarketWebService.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();

            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>().SingleInstance();
        }
    }
}
