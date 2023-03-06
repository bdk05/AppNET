using AppNET.Domain.Entities;
using AppNET.Domain.Interfaces;
using AppNET.Infrastructure;
using AppNET.Infrastructure.IOToTXT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNET.App
{
    public class ApplicationServiceSettings
    {
        public static void RegisterAllService()
        {
            //IOCContainer.Register("bir", 1);
            //IOCContainer.Register("bir", 11);
            //IOCContainer.Register("iki", 2);
            //IOCContainer.Register("üc", 3);
            //IOCContainer.Register("dört", 4);

            //IOCContainer.Register<IRepository<Category>>(Metot);
            IOCContainer.Register<IRepository<Category>>(()=>new TextFileRepository<Category>());
            IOCContainer.Register<ICategoryService>(() => new CategoryService());

            IOCContainer.Register<IRepository<Product>>(()=>new TextFileRepository<Product>());
            IOCContainer.Register <IProductService>(() => new ProductService());
        }
        public static IRepository<Category> Metot()
        {
            return new TextFileRepository<Category>();
        }

    }
}
