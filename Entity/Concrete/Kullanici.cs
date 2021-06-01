using MuhasebeApp.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MuhasebeApp.Entity.Concrete
{
    [Table("kullanici")]
    public class Kullanici : IEntity
    {
        [Column("id")]
        [Key]
        public int Id { get; set; }
        [Column("ad")]
        [MaxLength(250)]
        public string Ad { get; set; }
        [Column("soyad")]
        [MaxLength(250)]
        public string Soyad { get; set; }
        [Column("tc")]
        [MaxLength(11)]
        public string Tc { get; set; }
        [Column("password_salt")]
        public byte[] PasswordSalt { get; set; }
        [Column("password_hash")]
        public byte[] PasswordHash { get; set; }
    }
}
