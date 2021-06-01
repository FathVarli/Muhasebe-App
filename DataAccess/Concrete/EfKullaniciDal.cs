using MuhasebeApp.DataAccess.Abstract;
using MuhasebeApp.DataAccess.EntityFramework;
using MuhasebeApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MuhasebeApp.DataAccess.Concrete
{
    public class EfKullaniciDal:EntityRepositoryBase<Kullanici,PgDbContext>, IKullaniciDal
    {
    }
}
