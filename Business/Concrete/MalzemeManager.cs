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
    public class MalzemeManager : IMalzemeService
    {
        IMalzemeDal _malzemeDal;

        public MalzemeManager(IMalzemeDal malzemeDal)
        {
            _malzemeDal = malzemeDal;
        }

        public IResult Add(Malzeme malzeme)
        {
            Malzeme existMalzeme = _malzemeDal.Get(m => m.Ad == malzeme.Ad.ToUpper());
            if(existMalzeme != null)
            {
                return new ErrorResult("Bu malzeme ismi kullanılmaktadır!");
            }
            _malzemeDal.Add(malzeme);
            return new SuccessResult("Malzeme başarıyla eklenmiştir.");
        }

        public IResult DeleteById(int id)
        {
            Malzeme existMalzeme = _malzemeDal.Get(m => m.Id == id);
            if (existMalzeme == null)
            {
                return new ErrorResult("Silinecek malzeme bulunamadı!");
            }
            _malzemeDal.Delete(existMalzeme);
            return new SuccessResult("Malzeme başarıyla silindi");
        }

        public IDataResult<List<Malzeme>> GetAll()
        {
            List<Malzeme> malzemeList = _malzemeDal.GetList();
            return new SuccessDataResult<List<Malzeme>>(malzemeList);
            
        }

        public IDataResult<Malzeme> GetById(int id)
        {
            Malzeme existMalzeme = _malzemeDal.Get(m => m.Id == id);
            if (existMalzeme == null)
            {
                return new ErrorDataResult<Malzeme>("Silinecek malzeme bulunamadı!");
            }
            return new SuccessDataResult<Malzeme>(existMalzeme);
        }

        public IResult UpdateById(int id, Malzeme malzeme)
        {
            Malzeme existMalzeme = _malzemeDal.Get(m => m.Id == id);
            if (existMalzeme == null)
            {
                return new ErrorResult("Silinecek malzeme bulunamadı!");
            }
            if (!existMalzeme.Ad.Equals(malzeme.Ad) && !String.IsNullOrEmpty(malzeme.Ad))
            {
                Malzeme existMalzemeName = _malzemeDal.Get(m => m.Ad == malzeme.Ad.ToUpper());
                if (existMalzeme != null)
                {
                    return new ErrorResult("Bu malzeme ismi kullanılmaktadır!");
                }
                existMalzeme.Ad = malzeme.Ad.ToUpper();
            }
            if (String.IsNullOrEmpty(malzeme.Birim))
            {
                existMalzeme.Birim = malzeme.Birim;
            }
            _malzemeDal.Update(existMalzeme);
            return new SuccessResult("Malzeme başarıyla güncellenmiştir.");
        }
    }
}
