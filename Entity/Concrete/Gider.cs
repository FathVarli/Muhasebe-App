using MuhasebeApp.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    [Table("gider")]
    public class Gider : IEntity
    {
        [Column("id")]
        [Key]
        public int Id { get; set; }
        [Column("icerik")]
        [MaxLength(250)]
        public string Icerik { get; set; }
        [Column("toplam_tutar")]
        public decimal ToplamTutar { get; set; }
        [Column("tarih")]
        public DateTime Tarih { get; set; }
        [Column("ekleyen_kullanici_ad_soyad")]
        [MaxLength(250)]
        public string EkleyenKullaniciAdSoyad { get; set; }
        [Column("aciklama")]
        [MaxLength(500)]
        public string Aciklama { get; set; }

    }
}
