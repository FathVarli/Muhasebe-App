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
    [Table("malzeme")]
    public class Malzeme : IEntity
    {
        [Column("id")]
        [Key]
        public int Id { get; set; }
        [Column("ad")]
        [MaxLength(250)]
        public string Ad { get; set; }
        [Column("birim")]
        [MaxLength(250)]
        public string Birim { get; set; }
        [Column("birim_fiyat")]
        public decimal BirimFiyat { get; set; }

    }
}
