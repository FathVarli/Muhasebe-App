﻿using DataAccess.Abstract;
using Entity.Concrete;
using MuhasebeApp.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfMalzemeChartDal : EntityRepositoryBase<V_Malzeme_Chart, PgDbContext>, IMalzemeChartDal
    {
    }
}
