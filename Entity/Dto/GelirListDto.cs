using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dto
{
    public class GelirListDto
    {
        public int Id { get; set; }
        public decimal ToplamTutar { get; set; }
        public decimal AlinanTutar { get; set; }
        public DateTime Tarih { get; set; }
        public string MalzemeAdi { get; set; }
        public int Adet { get; set; }
        public string OdemeSekli { get; set; }
        public string Aciklama { get; set; }
    }
}
