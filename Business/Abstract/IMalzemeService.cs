using Entity.Concrete;
using MuhasebeApp.Core.Utils.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMalzemeService
    {
        IResult Add(Malzeme malzeme);
        IResult UpdateById(int id, Malzeme malzeme);
        IResult DeleteById(int id);
        IDataResult<Malzeme> GetById(int id);
        IDataResult<Malzeme> GetByName(string name);
        IDataResult<List<Malzeme>> GetAll();
        IDataResult<List<String>> GetAllMalzemeAdi();
        IDataResult<List<Malzeme>> GetAllListByMalzemeAdi(string ad);

    }
}
