using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationJwtAuth.Entities;
using WebApplicationJwtAuth.Controllers;

namespace WebApplicationJwtAuth.Repositories

{
    public interface ICarRepository
    {
        public void RemoveCar(int id);
        public void UpdateCar(int id, string model, string brand, int stock);
        public List<Car> GetAllCar();
        public void AddCar(Car car);
    }
}