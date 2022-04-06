using System;
//using WebApplicationJwtAuth.Controllers;
//using WebApplicationJwtAuth.Repositories;
using WebApplicationJwtAuth.Entities;


namespace WebApplicationJwtAuth.Entities
{
    public class Car
    {
        public Car(){}
        public int id = 1;
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Stock { get; set; }


        // ADD a car
        public Car(CarAdd car)
        {
            Id = id;
            Brand = car.Brand;
            Model = car.Model;
            Stock = car.Stock;

            //dupa adaugare incrementeaza id unic
            id++;

        }

        public void Sell(int stock)
        {
            Stock -= stock;
        }
    }
}