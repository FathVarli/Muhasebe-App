using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
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
            // Burası data access layer "Dal"
            Bind<IKullaniciDal>().To<EfKullaniciDal>().InSingletonScope();
            Bind<IGelirDal>().To<EfGelirDal>().InSingletonScope();
            Bind<IGiderDal>().To<EfGiderDal>().InSingletonScope();
            Bind<IMalzemeDal>().To<EfMalzemeDal>().InSingletonScope();

            // Burası business serviseler için
            Bind<IKullaniciService>().To<KullaniciManager>().InSingletonScope();
            Bind<IGiderService>().To<GiderManager>().InSingletonScope();
            Bind<IGelirService>().To<GelirManager>().InSingletonScope();
            Bind<IMalzemeService>().To<MalzemeManager>().InSingletonScope();






        }

    }
}
