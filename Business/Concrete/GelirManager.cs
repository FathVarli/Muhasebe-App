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
        public IResult AddGelir(Gelir gelir)
        {
            throw new NotImplementedException();
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
    }
}