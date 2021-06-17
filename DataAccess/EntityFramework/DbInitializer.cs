using Microsoft.EntityFrameworkCore;
using MuhasebeApp.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework
{
    public static class DbInitializer
    {
        public static void Initialize(PgDbContext context)
        {
            context.Database.ExecuteSqlRaw(@"CREATE or REPLACE VIEW V_Malzeme_Chart AS SELECT mal.ad AS malzeme_adi,date(tarih) AS tarih,sum(toplam_tutar) AS TOTAL FROM gelir gel
JOIN malzeme mal ON mal.id = gel.malzeme_id
 GROUP BY malzeme_id,tarih,mal.ad;");
        }
  
    }
}
