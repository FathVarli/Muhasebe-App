using Entity.Concrete;
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
        IResult AddGelir(Gelir gelir);
        IDataResult<Gelir> GetById(int id);
    }
}
