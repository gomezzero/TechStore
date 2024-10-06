// using System;
// using System.Collections.Generic;
// using System.Diagnostics;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.Extensions.Logging;
// using TechStore.Repositories;

// namespace TechStore.Controller.V1.Product
// {
//     [Route("api/v1/productcategories")]
//     [ApiExplorerSettings(GroupName = "v1")]
//     [Tags("productcategories")]
//     public class ProductCategorieGetController(IProductCategorieRepository productCategorieService) : ControllerBase
//     {
//         private readonly IProductCategorieRepository _productCategorieService = productCategorieService;

//         [HttpGet]
//         public async Task<IActionResult> GetAllCategories()
//         {
//             var categories = await _productCategorieService.GetAll();
//             return Ok(categories);
//         }

//         [HttpGet("{id}")]
//         public async Task<IActionResult> GetCategoryById(int id)
//         {
//             var category = await _productCategorieService.GetById(id);
//             if (category == null) return NotFound();
//             return Ok(category);
//         }

//         [HttpGet("search")]
//         public async Task<IActionResult> SearchCategories([FromQuery] string keyword)
//         {
//             var categories = await _productCategorieService.GetByKeyword(keyword);
//             return Ok(categories);
//         }
//     }
// }