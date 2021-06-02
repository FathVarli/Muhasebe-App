using MuhasebeApp.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Gider : IEntity
    {
        public int Id { get; set; }
        public string Icerik { get; set; }
        public decimal ToplamTutar { get; set; }
        public DateTime Tarih { get; set; }
        public string EkleyenKullaniciAdSoyad { get; set; }
        public string Aciklama { get; set; }

    }
}
