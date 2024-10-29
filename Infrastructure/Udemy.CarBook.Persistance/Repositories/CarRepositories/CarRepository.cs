using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Persistance.Context;
using UdemyCarBook.Application.Interfaces.CarInterfaces;
using UdemyCarBook.Domain.Entities;

namespace Udemy.CarBook.Persistance.Repositories.CarRepositories
{
    public class CarRepository : ICarRepository
    {
        private readonly CarBookContext _context;

        public CarRepository(CarBookContext context)
        {
            _context = context;
        }

        public int GetCarCount()
        {
            var values = _context.Cars.Count();
            return values;
        }

        public List<Car> GetCarsListWithBrand()
        {
            var values =_context.Cars.Include(x=>x.Brand).ToList();
            return values;
        }

		public List<Car> GetLast5CarsListWithBrand()
        {
            var values = _context.Cars.Include(_x => _x.Brand).OrderByDescending(x => x.CarID).Take(5).ToList();
            return values;
        }
    }
}
