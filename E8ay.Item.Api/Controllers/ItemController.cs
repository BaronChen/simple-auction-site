﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E8ay.Item.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E8ay.Item.Api.Controllers
{
    [Authorize(Policy = "ApiUser")]
    [Produces("application/json")]
    [Route("api/items")]
    public class ItemsController : Controller
    {
        private readonly IItemService _itemService;

        public ItemsController(IItemService itemService)
        {
            _itemService = itemService;
        }

        [HttpGet]
        [Route("")]
        public IActionResult List()
        {
            var items = _itemService.GetAllAuctionItems();

            return Ok(items);
        }


    }
}