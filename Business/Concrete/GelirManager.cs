using Business.Abstract;
using Core.Utils.Helper;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.Dto;
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
        IMalzemeDal _malzemeDal;
        public GelirManager(IGelirDal gelirDal, IMalzemeDal malzemeDal)
        {
            _gelirDal = gelirDal;
            _malzemeDal = malzemeDal;
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

        public IDataResult<List<Gelir>> GetAll()
        {
            return new SuccessDataResult<List<Gelir>>(_gelirDal.GetList());
        }

        public IDataResult<List<Gelir>> GetAllByFilter(GelirFilterDto gelirFilter)
        {
            var predicate = PredicateBuilder.True<Gelir>();


            if (gelirFilter.MalzemeId > 0)
            {
                predicate = predicate.And(p => p.MalzemeId == gelirFilter.MalzemeId);
            }
            if (!string.IsNullOrEmpty(gelirFilter.OdemeSekli))
            {
                predicate = predicate.And(p => p.OdemeSekli == gelirFilter.OdemeSekli);
            }
            if (gelirFilter.StartDate != null && gelirFilter.EndDate != null)
            {
                //gelirFilter.StartDate += "23:59";
                //gelirFilter.EndDate += "00:00";

                //string query = string.Format("SELECT * FROM gelir WHERE tarih >= '{0}' AND tarih <= '{1}'", gelirFilter.StartDate, gelirFilter.EndDate);
                //List<int> list = _gelirDal.GetListQuery(query);

                predicate = predicate.And(p => p.Tarih >= gelirFilter.StartDate && p.Tarih <= gelirFilter.EndDate);
            }

            var gelirList = _gelirDal.GetList(predicate);
            return new SuccessDataResult<List<Gelir>>(gelirList);
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
            if (gelir.MalzemeId > 0)
            {
                var existMalzeme =_malzemeDal.Get(m => m.Id == gelir.MalzemeId);
                if (existMalzeme == null)
                {
                    return new ErrorResult("Malzeme bulunamadı.");
                }
                existGelir.MalzemeId = gelir.MalzemeId;
            }
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