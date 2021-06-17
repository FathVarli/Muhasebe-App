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
    public class GiderManager : IGiderService
    {
        IGiderDal _giderDal;

        public GiderManager(IGiderDal giderDal)
        {
            this._giderDal = giderDal;
        }

        public IResult Add(Gider gider)
        {
            _giderDal.Add(gider);
            return new SuccessResult("Gider başarıyla eklendi.");
        }

        public IResult DeleteById(int id)
        {
            Gider gider = _giderDal.Get(g => g.Id == id);
            if (gider == null)
            {
                return new ErrorResult("Gider bulunamadı.");
            }
            _giderDal.Delete(gider);
            return new SuccessResult("Gider başarıyla silindi.");
        }

        public IDataResult<List<Gider>> GetAll()
        {
            return new SuccessDataResult<List<Gider>>(_giderDal.GetList());
        }

        public IDataResult<List<Gider>> GetAllByFilter(GiderFilterDto giderFilterDto)
        {
            var predicate = PredicateBuilder.True<Gider>();
            if (!string.IsNullOrEmpty(giderFilterDto.İcerik))
            {
                predicate = predicate.And(p => p.Icerik.Contains(giderFilterDto.İcerik));
            }
            if (giderFilterDto.StartDate != null && giderFilterDto.EndDate != null)
            {
                predicate = predicate.And(p => p.Tarih >= giderFilterDto.StartDate && p.Tarih < giderFilterDto.EndDate);
            }

            var giderList = _giderDal.GetList(predicate);
            return new SuccessDataResult<List<Gider>>(giderList);
        }

        public IDataResult<Gider> GetById(int id)
        {
            Gider gider = _giderDal.Get(g => g.Id == id);
            if (gider == null)
            {
                return new ErrorDataResult<Gider>("Gider bulunamadı.");
            }
            return new SuccessDataResult<Gider>(gider);
        }

        public IResult UpdateById(int id, Gider gider)
        {
            Gider existGider = _giderDal.Get(g => g.Id == id);
            if (gider == null)
            {
                return new ErrorResult("Gider bulunamadı.");
            }
            if (!String.IsNullOrEmpty(gider.Icerik))
            {
                existGider.Icerik = gider.Icerik;
            }
            if (!String.IsNullOrEmpty(gider.Aciklama))
            {
                existGider.Aciklama = gider.Aciklama;
            }
           
            if (gider.ToplamTutar > 0)
            {
                existGider.ToplamTutar = gider.ToplamTutar;
            }
            if (gider.Tarih != null)
            {
                existGider.Tarih = gider.Tarih;
            }
            gider.Tarih = new DateTime(gider.Tarih.Year, gider.Tarih.Month, gider.Tarih.Day);
            _giderDal.Update(existGider);
            return new SuccessResult("Gider başarıyla güncellendi");
        }
    }
}
