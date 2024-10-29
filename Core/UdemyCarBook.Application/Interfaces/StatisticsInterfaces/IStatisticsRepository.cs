using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Application.Interfaces.StatisticsInterfaces
{
    public interface IStatisticsRepository
    {
        int GetCarCount(); //Araba Sayısı
        int GetLocationCount(); //lokasyon sayısı
        int GetAuthorCount(); //yazar sayısı
        int GetBlogCount(); //blog sayısı
        int GetBrandCount(); //marka sayısı

        decimal GetAvgRentPriceForDaily(); //günlük ortalama araç kiralama fiyatı
        decimal GetAvgRentPriceForWeekly();//haftalık ortalama araç kiralama fiyatı
        decimal GetAvgRentPriceForMonthly();//aylık ortalama araç kiralama fiyatı

        int GetCarCountByTransmissionIsAuto(); //otomatik vites araba sayısı

        string GetBrandNameByMaxCar(); //en fazla araca sahip markanın adı
        string GetBlogTitleByMaxBlogComment(); //en fazla yoruma sahip blogun adı

        int GetCarCountByKmSmallerThen1000(); //km'si 1000 den düşük araç sayısı

        int GetCarCountByFuelGasolineOrDisel(); // benzin veya dize laraç sayısı

        int GetCarCountByElectric(); //elektirikli araç sayısı

        string GetCarBrandAndModelByRentPriceDailyMax(); //günlük kiralama bedeli en pahalı olan araç
        string GetCarBrandAndModelByRentPriceDailyMin();//günlük kiralama bedeli en ucuz olan araç
    }
}
