using MuhasebeApp.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{

    public class V_Malzeme_Chart : IEntity
    {
        [Column("total")]
        public decimal Total { get; set; }
        [Column("malzeme_adi")]
        public string MalzemeAdi  { get; set; }
    }
}
