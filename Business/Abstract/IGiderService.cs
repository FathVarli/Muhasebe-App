using Entity.Concrete;
using MuhasebeApp.Core.Utils.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IGiderService
    {
        IResult Add(Gider gider);
        IResult UpdateById(int id,Gider gider);
        IResult DeleteById(int id);
        IDataResult<Gider> getById(int id);
        IDataResult<List<Gider>> getAll();
    }
}
