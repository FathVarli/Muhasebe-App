using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.Dto;
using MuhasebeApp.Core.Utils.Methods;
using MuhasebeApp.Core.Utils.Results;
using System;
using System.Collections.Generic;


namespace Business.Concrete
{
    public class RaporManager : IRaporService
    {
        IMalzemeDal _malzemeDal;
        IGelirDal _gelirDal;
        IGiderDal _giderDal;
        IMalzemeChartDal _malzemeChartDal;

        public RaporManager(IGiderDal giderDal, IGelirDal gelirDal, IMalzemeDal malzemeDal, IMalzemeChartDal malzemeChartDal)
        {
            _giderDal = giderDal;
            _gelirDal = gelirDal;
            _malzemeDal = malzemeDal;
            _malzemeChartDal = malzemeChartDal;
        }

        public IDataResult<ToplamGelirGiderDto> CalculataToplamGelirGiderByMonthAndYear(int monthId, int year)
        {
            decimal toplamGelir = 0;

            var gelirList = _gelirDal.GetList(g => g.Tarih.Month == monthId && g.Tarih.Year == year);
            foreach (var gelir in gelirList)
            {
                toplamGelir += gelir.AlinanTutar;
            }

            decimal toplamGider = 0;

            var giderList = _giderDal.GetList(g => g.Tarih.Month == monthId && g.Tarih.Year == year);
            foreach (var gider in giderList)
            {
                toplamGider += gider.ToplamTutar;
            }

            decimal kar = 0;
            decimal zarar = 0;
            if (toplamGelir > toplamGider)
            {
                kar = toplamGelir - toplamGider;
            }
            else
            {
                zarar = toplamGider - toplamGelir;
            }
            var toplamGelirGiderDto = new ToplamGelirGiderDto
            {
                ToplamGelir = toplamGelir,
                ToplamGider = toplamGider,
                ToplamKar = kar,
                ToplamZarar = zarar
            };

            return new SuccessDataResult<ToplamGelirGiderDto>(toplamGelirGiderDto);
        }

        public IDataResult<List<V_Malzeme_Chart>> CalculataTotalGelirByMalzemeName()
        {
            var currentDate = DateTime.Now;

            var malzemeChartList = _malzemeChartDal.GetList(m => m.Tarih.Month == currentDate.Month && m.Tarih.Year == currentDate.Year);
            return new SuccessDataResult<List<V_Malzeme_Chart>>(malzemeChartList);
        }

        public IDataResult<List<YillikChartToplamGelirGiderDto>> CalculateLastOneYearTotalGelirGider()
        {

            var startDate = DateTime.Now;
            var yillikChartList = new List<YillikChartToplamGelirGiderDto>();
            for (int i = 0; i < 12; i++)
            {
      
                decimal toplamGelir = 0;

                var gelirList = _gelirDal.GetList(g => g.Tarih.Month == startDate.Month && g.Tarih.Year == startDate.Year);
                foreach (var gelir in gelirList)
                {
                    toplamGelir += gelir.AlinanTutar;
                }

                decimal toplamGider = 0;

                var giderList = _giderDal.GetList(g => g.Tarih.Month == startDate.Month && g.Tarih.Year == startDate.Year);
                foreach (var gider in giderList)
                {
                    toplamGider += gider.ToplamTutar;
                }
                var yillikCart = new YillikChartToplamGelirGiderDto
                {

                    ToplamGelir = toplamGelir,
                    ToplamGider = toplamGider,
                    AyAdi = Aylar.getAyById(startDate.Month).Adi,
                    AyId = startDate.Month
                };
                yillikChartList.Add(yillikCart);

                startDate = startDate.AddMonths(-1);
            }
            return new SuccessDataResult<List<YillikChartToplamGelirGiderDto>>(yillikChartList);


        }

        public IDataResult<ToplamGelirGiderDto> CalculateToplamGelirGider()
        {


            List<Gelir> gelirList = _gelirDal.GetList();
            decimal totalGelirMoney = 0;
            decimal totalGiderMoney = 0;

            foreach (var gelir in gelirList)
            {
                totalGelirMoney += gelir.AlinanTutar;
            }

            List<Gider> giderList = _giderDal.GetList();
            foreach (var gider in giderList)
            {
                totalGiderMoney += gider.ToplamTutar;
            }

            decimal kar = 0;
            decimal zarar = 0;
            if (totalGiderMoney > totalGelirMoney)
            {
                zarar = totalGiderMoney - totalGelirMoney;
            }
            else
            {
                kar = totalGelirMoney - totalGiderMoney;
            }
            var toplamGelirGiderDto = new ToplamGelirGiderDto
            {
                ToplamGelir = totalGelirMoney,
                ToplamGider = totalGiderMoney,
                ToplamKar = kar,
                ToplamZarar = zarar

            };

            return new SuccessDataResult<ToplamGelirGiderDto>(toplamGelirGiderDto);
        }

    }
}
