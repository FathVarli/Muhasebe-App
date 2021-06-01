using MuhasebeApp.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    class Gelir : IEntity
    {
        public int Id { get; set; }
        public decimal ToplamTutar { get; set; }
        public decimal AlinanTutar { get; set; }
        public DateTime Tarih { get; set; }
        public int MalzemeId { get; set; }
        public int Adet { get; set; }
        public string OdemeSekli { get; set; }
        public string Aciklama { get; set; }
    }
}
