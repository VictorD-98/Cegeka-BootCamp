﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationJwtAuth;
using WebApplicationJwtAuth.Entities;
//using WebApplicationJwtAuth.Entities.Deposits;
//using WebApplicationJwtAuth.Entities.Requests;

namespace WebApplicationJwtAuth.Repositories
{
    public class CarRepository : ICarRepository
    {
        public void AddCar(Car car)
        {
            DepositCar.Add(car);
        }

        public List<Car> GetAllCar()
        {
            return DepositCar.GetAll();
        }

        public void RemoveCar(int id)
        {
            DepositCar.RemoveCar(id);
        }

        public void UpdateCar(int id, string model, string brand, int stock)
        {
            DepositCar.UpdateCar(id, model, brand, stock);
        }
    }
}
