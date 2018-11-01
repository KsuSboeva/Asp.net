using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Moq;
using DressChop.Domain.Entities;
using DressChop.Domain.Abstract;
using DressChop.Domain.Context;

namespace DressChop.WebUI.Infrastructure
{
    //пользовательская фабрика контроллеров
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }  
        private void AddBindings()
       {
            //объект для императивного хранилища данных
            //        Mock<IProductsRepository> mock = new Mock<IProductsRepository>();
            //        mock.Setup(m => m.Products).Returns(new List<Product>
            //{
            //    new Product { Name = "Coat", Price = 1500 },
            //    new Product { Name = "Sweater ", Price=2299 },
            //    new Product { Name = "Pan", Price=899.4M }
            //});
            //kernel.Bind<IProductsRepository>().ToConstant(mock.Object);

            //привязка к реальному хранилищу

            kernel.Bind<IProductsRepository>().To<EntityProductRepository>();
        }
    }
}