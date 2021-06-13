using System;
using System.Collections.Generic;
using System.Text;

namespace MuhasebeApp.Core.Utils.Methods
{
    public static class Aylar
    {
        public static List<Ay> getAllAy()
        {
            List<Ay> ayList = new List<Ay>();

            ayList.Add(new Ay(1, "OCAK"));
            ayList.Add(new Ay(2, "ŞUBAT"));
            ayList.Add(new Ay(3, "MART"));
            ayList.Add(new Ay(4, "NİSAN"));
            ayList.Add(new Ay(5, "MAYIS"));
            ayList.Add(new Ay(6, "HAZİRAN"));
            ayList.Add(new Ay(7, "TEMMUZ"));
            ayList.Add(new Ay(8, "AĞUSTOS"));
            ayList.Add(new Ay(9, "EYLÜL"));
            ayList.Add(new Ay(10, "EKİM"));
            ayList.Add(new Ay(11, "KASIM"));
            ayList.Add(new Ay(12, "ARALIK"));

            return ayList;
        }

        public static Ay getAyById(int id)
        {
            var ayList = getAllAy();
            return ayList.Find(a => a.Id == id);
        }

    }

    public class Ay
    {
        public int Id { get; set; }
        public string Adi { get; set; }

        public Ay(int id, String adi)
        {
            this.Id = id;
            this.Adi = adi;
        }
    }
}
