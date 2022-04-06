﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;

using WebApplicationJwtAuth.Entities;
//using WebApplicationJwtAuth.Entities.Requests;
//using WebApplicationJwtAuth.Entities.Deposits;
using WebApplicationJwtAuth.Repositories;



namespace WebApplicationJwtAuth.Controllers
{
    public class BuyController : Controller
    {
        private IBuyRepository _buyRepository { get; set; }

        public BuyController(IBuyRepository buyRepository)
        {
            _buyRepository = buyRepository;
        }

        [HttpPost("addBuy")]
        public async Task<IActionResult> Buy(int idCar, int idCustomer, int stock)
        {
            _buyRepository.Buy(idCar, idCustomer, stock);
            return Ok();
        }

        [HttpGet("getBuy")]
        public async Task<IActionResult> GetBuy()
        {
            var buy = _buyRepository.GetBuy();
            return Ok(buy);
        }

        [HttpGet("filterBuy")]
        public async Task<IActionResult> FilterBuy(string param, string filter)
        {
            var buy = _buyRepository.FilterBuy(param, filter);
            return Ok(buy);
        }
    }
}
