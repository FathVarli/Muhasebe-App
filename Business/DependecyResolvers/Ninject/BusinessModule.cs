using MuhasebeApp.Business.Abstract;
using MuhasebeApp.Business.Concrete;
using MuhasebeApp.DataAccess.Abstract;
using MuhasebeApp.DataAccess.Concrete;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace MuhasebeApp.Business.DependecyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
           Bind<IKullaniciDal>().To<EfKullaniciDal>().InSingletonScope();


           Bind<IKullaniciService>().To<KullaniciManager>().InSingletonScope();

        }

    }
}
