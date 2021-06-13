using Entity.Concrete;
using MuhasebeApp.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IMalzemeChartDal : IEntityRepository<V_Malzeme_Chart>
    {
    }
}
