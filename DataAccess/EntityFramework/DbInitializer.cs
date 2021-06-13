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
            context.Database.ExecuteSqlRaw(@"CREATE or REPLACE VIEW V_Malzeme_Chart AS SELECT SUM(toplam_tutar) AS total, mal.ad as malzeme_adi FROM gelir gel JOIN malzeme mal ON mal.id = gel.id GROUP BY mal.ad;");
        }
    }
}
