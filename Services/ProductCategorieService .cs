// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.EntityFrameworkCore;
// using TechStore.Data;
// using TechStore.DTOs;
// using TechStore.Models;
// using TechStore.Repositories;

// namespace TechStore.Services
// {
//     public class ProductCategorieService : IProductCategorieRepository
//     {
//         private readonly MyDbContext _context;

//         public ProductCategorieService(MyDbContext context)
//         {
//             _context = context;
//         }

//         public async Task<IEnumerable<ProductCategorie>> GetAll()
//         {
//             return await _context.ProductCategories.ToListAsync();
//         }

//         public async Task<ProductCategorie?> GetById(int id)
//         {
//             return await _context.ProductCategories.FindAsync(id);
//         }

//         public async Task<IEnumerable<ProductCategorie>> GetByKeyword(string keyword)
//         {
//             if (string.IsNullOrWhiteSpace(keyword))
//             {
//                 return await GetAll();
//             }

//             return await _context.ProductCategories.Where(pc => pc.Name.Contains(keyword)).ToListAsync();
//         }

//         public async Task<ProductCategorie> Create(ProductCategorieDTO dto)
//         {
//             var category = new ProductCategorie(dto.Name, dto.Description);
//             _context.ProductCategories.Add(category);
//             await _context.SaveChangesAsync();
//             return category;
//         }

//         public async Task Update(int id, ProductCategorieDTO dto)
//         {
//             var category = await GetById(id);
//             if (category == null) return;

//             category.Name = dto.Name.ToLower().Trim();
//             category.Description = dto.Description?.ToLower().Trim();
//             await _context.SaveChangesAsync();
//         }

//         public async Task Delete(int id)
//         {
//             var category = await GetById(id);
//             if (category != null)
//             {
//                 _context.ProductCategories.Remove(category);
//                 await _context.SaveChangesAsync();
//             }
//         }
//     }
// }
