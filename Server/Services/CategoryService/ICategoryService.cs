﻿using BlazingShop.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazingShop.Server.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<List<Category>> GetCategories();

        Task<Category> GetCategoryByUrl(string categoryUrl);
    }
}
