using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Persistance.Context;
using UdemyCarBook.Application.Interfaces.CarPricingInterfaces;
using UdemyCarBook.Application.ViewModels;
using UdemyCarBook.Domain.Entities;

namespace Udemy.CarBook.Persistance.Repositories.CarPricingRepositories
{
	public class CarPricingRepository : ICarPricingRepository
	{
		private readonly CarBookContext _context;

		public CarPricingRepository(CarBookContext context)
		{
			_context = context;
		}

		public List<CarPricing> GetCarPricingWithCars()
		{
			var values = _context.CarPricings.Include(x => x.Car).ThenInclude(y => y.Brand).Include(x => x.Pricing).Where(q=>q.PricingID==2).ToList();
			//CarpricingId si 2 olanları yani pricing günlük olanları listeliycek böylelikle car sayfasında(Car/Index) ödeme kısmı günlük fiyatlardan listelenecek
			return values;
		}

		public List<CarPricingViewModel> GetCarPricingWithTimePeriod()
		{
			List<CarPricingViewModel> values = new List<CarPricingViewModel>();
			using (var command = _context.Database.GetDbConnection().CreateCommand())
			{
				command.CommandText = "Select * From (Select Model,Name,CoverImageUrl,PricingID,Amount From CarPricings Inner Join Cars On Cars.CarID=CarPricings.CarId Inner Join Brands On Brands.BrandID=Cars.BrandID) As SourceTable Pivot (Sum(Amount) For PricingID In ([3],[4],[8])) as PivotTable;";
				command.CommandType = System.Data.CommandType.Text;
				_context.Database.OpenConnection();
				using (var reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						CarPricingViewModel carPricingViewModel = new CarPricingViewModel()
						{
							Brand = reader["Name"].ToString(),
							Model = reader["Model"].ToString(),
							CoverImageUrl = reader["CoverImageUrl"].ToString(),
							Amounts = new List<decimal>
							{
								Convert.ToDecimal(reader["3"]),
								Convert.ToDecimal(reader["4"]),
								Convert.ToDecimal(reader["8"])
							}
						};
						values.Add(carPricingViewModel);
					}
				}
				_context.Database.CloseConnection();
				return values;
			}
		}
	}
}
