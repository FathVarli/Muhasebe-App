using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dto
{
    public class YillikChartToplamGelirGiderDto
    {
        public string AyAdi { get; set; }
        public decimal ToplamGelir { get; set; }
        public decimal ToplamGider { get; set; }
    }
}
