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
    [Table("gelir")]
    public class Gelir : IEntity
    {
        [Column("id")]
        [Key]
        public int Id { get; set; }
        [Column("toplam_tutar")]
        public decimal ToplamTutar { get; set; }
        [Column("alinan_tutar")]
        public decimal AlinanTutar { get; set; }
        [Column("tarih")]
        public DateTime Tarih { get; set; }
        [Column("malzeme_id")]
        public int MalzemeId { get; set; }
        [Column("adet")]
        public int Adet { get; set; }
        [Column("odeme_sekli")]
        [MaxLength(250)]
        public string OdemeSekli { get; set; }
        [Column("aciklama")]
        [MaxLength(500)]
        public string Aciklama { get; set; }
        [Column("ekleyen_kullanici_ad_soyad")]
        [MaxLength(500)]
        public string EkleyenKullaniciAdSoyad { get; set; }
    }
}
