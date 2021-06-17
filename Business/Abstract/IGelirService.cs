using Entity.Concrete;
using Entity.Dto;
using MuhasebeApp.Core.Utils.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IGelirService
    {
        IResult Add(Gelir gelir);
        IResult DeleteById(int id);
        IResult UpdateById(int id, Gelir gelir);
        IDataResult<Gelir> GetById(int id);
        IDataResult<List<GelirListDto>> GetAll();
        IDataResult<List<GelirListDto>> GetAllByFilter(GelirFilterDto gelirFilter);



    }
}
