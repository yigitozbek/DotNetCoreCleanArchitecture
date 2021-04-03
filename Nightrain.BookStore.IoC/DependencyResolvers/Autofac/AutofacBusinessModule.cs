using Autofac;
using Nightrain.Base.Core.DataAccessLayers.Abstract;
using Nightrain.Base.Core.DataAccessLayers.Concrete.Dapper;
using Nightrain.BookStore.Data.Context;
using Nightrain.BookStore.Data.Repositories.EntityFrameworkCore;
using Nightrain.BookStore.Domain.Interfaces;

namespace Nightrain.BookStore.IoC.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EfCoreAuthorRepository>().As<IAuthorRepository>();
            builder.RegisterType<EfCoreBookRepository>().As<IBookRepository>();
            builder.RegisterType<EfCoreBookCategoryRepository>().As<IBookCategoryRepository>();
            builder.RegisterType<EfCoreBookFormatRepository>().As<IBookFormatRepository>();
            builder.RegisterType<EfCoreBookSizeRepository>().As<IBookSizeRepository>();
            builder.RegisterType<EfCoreCategoryRepository>().As<ICategoryRepository>();
            builder.RegisterType<EfCoreCoverRepository>().As<ICoverRepository>();
            builder.RegisterType<EfCoreLanguageRepository>().As<ILanguageRepository>();
            builder.RegisterType<EfCorePublisherRepository>().As<IPublisherRepository>();
            builder.RegisterType<EfCoreAuthorBookRepository>().As<IAuthorBookRepository>();
            builder.RegisterType<DapperRepository>().As<IDapper>();
            builder.RegisterType<ApplicationDbContext>().As<IApplicationDbContext>().InstancePerDependency();
        }
    }
}
