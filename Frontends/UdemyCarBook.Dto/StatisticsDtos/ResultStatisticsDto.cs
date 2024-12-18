﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Dto.StatisticsDtos
{
    public class ResultStatisticsDto
    {
        public int carCount { get; set; }
        public int locationCount { get; set; }
        public int authorCount { get; set; }
        public int blogCount { get; set; }
        public int brandCount { get; set; }
        public decimal avgPriceForDaily { get; set; }
        public decimal getAvgPriceForWeekly { get; set; }
        public decimal getAvgPriceForMonthly { get; set; }
        public int getCarCountByTransmissionIsAuto { get; set; }
        public int GetCarCountByKmSmallerThen1000 { get; set; }
        public int GetCarCountByFuelGasolineOrDisel { get; set; }
        public int GetCarCountByElectric { get; set; }
        public string GetCarBrandAndModelByRentPriceDailyMax { get; set; }
        public string GetCarBrandAndModelByRentPriceDailyMin { get; set; }
        public string GetBrandNameByMaxCar { get; set; }
        public string GetBlogTİtleByMaxBlogComment { get; set; }
    }
}
