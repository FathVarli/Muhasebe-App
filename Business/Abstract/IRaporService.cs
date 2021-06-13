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
    public interface IRaporService
    {
        IDataResult<ToplamGelirGiderDto> CalculateToplamGelirGider();
        IDataResult<ToplamGelirGiderDto> CalculataToplamGelirGiderByMonthAndYear(int monthId,int year);
        IDataResult<List<V_Malzeme_Chart>> CalculataTotalGelirByMalzemeName();
        IDataResult<List<YillikChartToplamGelirGiderDto>> CalculateLastOneYearTotalGelirGider();

    }
}
