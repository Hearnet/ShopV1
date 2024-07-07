﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopV1.Application.Catalog.Categories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ShopV1.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(
            ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(string languageId)
        {
            var products = await _categoryService.GetAll(languageId);
            return Ok(products);
        }
    }
}
