using MuhasebeApp.DataAccess.EntityFramework;
using MuhasebeApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MuhasebeApp.DataAccess.Abstract
{
    public interface IKullaniciDal : IEntityRepository<Kullanici>
    {
    }
}
