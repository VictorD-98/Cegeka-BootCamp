using WebApplicationJwtAuth.Entities;
//using WebApplicationJwtAuth.Entities.Requests;
//using WebApplicationJwtAuth.Entities.Deposits;
using WebApplicationJwtAuth.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApplicationJwtAuth.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class CarController : ControllerBase
    {
        private ICarRepository _carRepository { get; set; }

        public CarController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }


        // POST new car
        [HttpPost ("addCar")]
        public async Task<IActionResult> AddCar (CarAdd car)
        {
            _carRepository.AddCar(new Car(car));
            return Ok();
        }

        // DELETE car entry
        [HttpDelete("removeCar")]
        public async Task<IActionResult> RemoveCar(int id)
        {
            _carRepository.RemoveCar(id);
            return Ok();
        }

        // PATCH update stock
        [HttpPatch("updateCar")]
        public async Task<ActionResult> UpdateCar(int id, string model, string brand, int stock)
        {
            _carRepository.UpdateCar(id, model, brand, stock);
            return Ok();
        }

        [HttpGet("getCar")]
        public async Task<IActionResult> GetCar()
        {
            var cars = _carRepository.GetAllCar();
            return Ok(cars);
        }
    }
}
