// using System;
// using System.Collections.Generic;
// using System.Diagnostics;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.Extensions.Logging;
// using TechStore.DTOs;
// using TechStore.Repositories;

// namespace TechStore.Controller.V1.Product
// {
//     [Route("[controller]")]
//     public class ProductCategoriePostController(IProductCategorieRepository productCategorieService) : ControllerBase
//     {
//         private readonly IProductCategorieRepository _productCategorieService = productCategorieService;

//         [HttpPost]
//         public async Task<IActionResult> CreateCategory([FromBody] ProductCategorieDTO dto)
//         {
//             if (!ModelState.IsValid)
//             {
//                 return BadRequest(ModelState);
//             }

//             var category = await _productCategorieService.Create(dto);
            
//         }
//     }
// }