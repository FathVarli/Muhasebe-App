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
            var gelirQuery = string.Format("SELECT SUM(toplam_tutar) AS total FROM gelir WHERE DATE_PART('month',tarih) = {0} AND DATE_PART('year', tarih) = {1};", monthId, year);
            var toplamGelir = _gelirDal.GetTotalMoney(gelirQuery);
            var giderQuery = string.Format("SELECT SUM(toplam_tutar) AS total FROM gider WHERE DATE_PART('month',tarih) = {0} AND DATE_PART('year', tarih) = {1};", monthId, year);
            var toplamGider = _gelirDal.GetTotalMoney(giderQuery);

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
            //aylık olarak düzenlenecek
            var malzemeChartList = _malzemeChartDal.GetList();
            return new SuccessDataResult<List<V_Malzeme_Chart>>(malzemeChartList);
        }

        public IDataResult<List<YillikChartToplamGelirGiderDto>> CalculateLastOneYearTotalGelirGider()
        {

            var startDate = DateTime.Now;
            var yillikChartList = new List<YillikChartToplamGelirGiderDto>();
            for (int i = 0; i < 12; i++)
            {
                var gelirQuery = string.Format("SELECT SUM(toplam_tutar) AS total FROM gelir WHERE DATE_PART('month',tarih) = {0} AND DATE_PART('year', tarih) = {1};", startDate.Month, startDate.Year);
                var toplamGelir = _gelirDal.GetTotalMoney(gelirQuery);
                var giderQuery = string.Format("SELECT SUM(toplam_tutar) AS total FROM gider WHERE DATE_PART('month',tarih) = {0} AND DATE_PART('year', tarih) = {1};", startDate.Month, startDate.Year);
                var toplamGider = _gelirDal.GetTotalMoney(giderQuery);
                var yillikCart = new YillikChartToplamGelirGiderDto
                {

                    ToplamGelir = toplamGelir,
                    ToplamGider = toplamGider,
                    AyAdi = Aylar.getAyById(startDate.Month).Adi
                };
                yillikChartList.Add(yillikCart);

                startDate = startDate.AddMonths(-1);
            }

            return new SuccessDataResult<List<YillikChartToplamGelirGiderDto>>(yillikChartList);


        }

        public IDataResult<ToplamGelirGiderDto> CalculateToplamGelirGider()
        {
            var queryGelir = string.Format("SELECT SUM(toplam_tutar) AS total FROM gelir;");
            var totalGelirMoney = _gelirDal.GetTotalMoney(queryGelir);
            var queryGider = string.Format("SELECT SUM(toplam_tutar) AS total FROM gider;");
            var totalGiderMoney = _giderDal.GetTotalMoney(queryGelir);
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
