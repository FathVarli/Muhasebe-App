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
            if(gider == null)
            {
                return new ErrorResult("Gider bulunamadı.");
            }
            _giderDal.Delete(gider);
            return new SuccessResult("Gider başarıyla silindi.");
        }

        public IDataResult<List<Gider>> getAll()
        {
            return new SuccessDataResult<List<Gider>>(_giderDal.GetList());
        }

        public IDataResult<Gider> getById(int id)
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
            if (!String.IsNullOrEmpty(gider.EkleyenKullaniciAdSoyad))
            {
                existGider.EkleyenKullaniciAdSoyad = gider.EkleyenKullaniciAdSoyad;
            }
            if(gider.ToplamTutar > 0)
            {
                existGider.ToplamTutar = gider.ToplamTutar;
            }
            if(gider.Tarih != null)
            {
                existGider.Tarih = gider.Tarih;
            }

            _giderDal.Update(existGider);
            return new SuccessResult("Gider başarıyla güncellendi");
        }
    }
}
