using AppLocaCar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLocaCar.Domain.Interfaces.Services
{
    public interface ICarsServiceRead
    {

        ICollection<Car> GetAvailableCars(DateTime start, DateTime end, string location);
        ICollection<Car> GetAllCars(string orderBy);
        Task<bool> RentCar(DateTime start, DateTime end, int cardId);
        Task<Car> FindCar(int id);
        Task<string> GetCarModelById(int id);
        Task<bool> IsAlreadyRented(DateTime start, DateTime end, int cardId);


    }
}
