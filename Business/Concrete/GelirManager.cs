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
            if (gelir.AlinanTutar > gelir.ToplamTutar)
            {
                return new ErrorResult("Alınan tutar toplam tutardan fazla olamaz!");
            }
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

        public IDataResult<List<GelirListDto>> GetAll()
        {
            var gelirDtoList = new List<GelirListDto>();
            var gelirList = _gelirDal.GetList();
            foreach (var gelir in gelirList)
            {
                var malzeme = _malzemeDal.Get(m => m.Id == gelir.MalzemeId);
                var gelirListDto = new GelirListDto
                {
                    Id = gelir.Id,
                    MalzemeAdi = malzeme.Ad,
                    Adet = gelir.Adet,
                    ToplamTutar = gelir.ToplamTutar,
                    AlinanTutar = gelir.AlinanTutar,
                    OdemeSekli = gelir.OdemeSekli,
                    Tarih = gelir.Tarih,
                    Aciklama = gelir.Aciklama,
                };
                gelirDtoList.Add(gelirListDto);
            }
            gelirDtoList = gelirDtoList.OrderBy(g => g.Id).ToList();
            return new SuccessDataResult<List<GelirListDto>>(gelirDtoList);
        }

        public IDataResult<List<GelirListDto>> GetAllByFilter(GelirFilterDto gelirFilter)
        {
            var gelirDtoList = new List<GelirListDto>();
            var predicate = PredicateBuilder.True<Gelir>();


            if (!string.IsNullOrEmpty(gelirFilter.MalzemeAd))
            {
                var malzemeId = _malzemeDal.Get(m => m.Ad == gelirFilter.MalzemeAd);
                predicate = predicate.And(p => p.MalzemeId == malzemeId.Id);
            }
            if (!string.IsNullOrEmpty(gelirFilter.OdemeSekli))
            {
                predicate = predicate.And(p => p.OdemeSekli == gelirFilter.OdemeSekli);
            }
            if (gelirFilter.StartDate != null && gelirFilter.EndDate != null)
            {
                predicate = predicate.And(p => p.Tarih >= gelirFilter.StartDate && p.Tarih <= gelirFilter.EndDate);
            }

            var gelirList = _gelirDal.GetList(predicate);
            foreach (var gelir in gelirList)
            {
                var malzeme = _malzemeDal.Get(m => m.Id == gelir.MalzemeId);
                var gelirListDto = new GelirListDto
                {
                    Id = gelir.Id,
                    MalzemeAdi = malzeme.Ad,
                    Adet = gelir.Adet,
                    ToplamTutar = gelir.ToplamTutar,
                    AlinanTutar = gelir.AlinanTutar,
                    OdemeSekli = gelir.OdemeSekli,
                    Tarih = gelir.Tarih,
                    Aciklama = gelir.Aciklama,
                };
                gelirDtoList.Add(gelirListDto);
            }
            return new SuccessDataResult<List<GelirListDto>>(gelirDtoList);
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
            if (gelir.AlinanTutar > gelir.ToplamTutar)
            {
                return new ErrorResult("Alınan tutar toplam tutardan fazla olamaz!");
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
                var existMalzeme = _malzemeDal.Get(m => m.Id == gelir.MalzemeId);
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


            _gelirDal.Update(existGelir);
            return new SuccessResult("Gelir başarıyla güncellendi");
        }
    }
}