using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using MuhasebeApp.Core.Utils.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class GelirManager : IGelirService
    {
        IGelirDal _gelirDal;
        public GelirManager(IGelirDal gelirDal)
        {
            _gelirDal = gelirDal;
        }

        public IResult Add(Gelir gelir)
        {
            _gelirDal.Add(gelir);
            return new SuccessResult("Gelir başarıyla eklendi.");
        }

        public IResult DeleteById(int id)
        {
            Gelir gelir = _gelirDal.Get(g => g.Id == id);
            if (gelir == null)
            {
                return new ErrorResult("Gelir bulunamadı.");
            }
            _gelirDal.Delete(gelir);
            return new SuccessResult("Gelir başarıyla silindi.");
        }

        public IDataResult<List<Gelir>> getAll()
        {
            return new SuccessDataResult<List<Gelir>>(_gelirDal.GetList());
        }

        public IDataResult<Gelir> GetById(int id)
        {
            Gelir existGelir = _gelirDal.Get(g => g.Id == id);
            if (existGelir == null)
            {
                return new ErrorDataResult<Gelir>("Gelir bulunamadı!");
            }
            return new SuccessDataResult<Gelir>(existGelir);
        }

        public IResult UpdateById(int id, Gelir gelir)
        {
            Gelir existGelir = _gelirDal.Get(g => g.Id == id);
            if (gelir == null)
            {
                return new ErrorResult("Gelir bulunamadı.");
            }
            if (gelir.ToplamTutar > 0)
            {
                existGelir.ToplamTutar = gelir.ToplamTutar;
            }
            if (gelir.AlinanTutar > 0)
            {
                existGelir.AlinanTutar = gelir.AlinanTutar;
            }
            if (gelir.Tarih != null)
            {
                existGelir.Tarih = gelir.Tarih;
            }
            //if (gelir.MalzemeId)
            //{

            //}
            if (gelir.Adet > 0)
            {
                existGelir.Adet = gelir.Adet;
            }
            if (!String.IsNullOrEmpty(gelir.OdemeSekli))
            {
                existGelir.OdemeSekli = gelir.OdemeSekli;
            }
            if (!String.IsNullOrEmpty(gelir.Aciklama))
            {
                existGelir.Aciklama = gelir.Aciklama;
            }
            if (!String.IsNullOrEmpty(gelir.EkleyenKullaniciAdSoyad))
            {
                existGelir.EkleyenKullaniciAdSoyad = gelir.EkleyenKullaniciAdSoyad;
            }

            _gelirDal.Update(existGelir);
            return new SuccessResult("Gelir başarıyla güncellendi");
        }
    }
}