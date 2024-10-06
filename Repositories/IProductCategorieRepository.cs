// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using TechStore.DTOs;
// using TechStore.Models;

// namespace TechStore.Repositories
// {
//     public interface IProductCategorieRepository
//     {
//         Task<IEnumerable<ProductCategorie>> GetAll();
//         Task<ProductCategorie?> GetById(int id);
//         Task<IEnumerable<ProductCategorie>> GetByKeyword(string keyword);
//         Task<ProductCategorie> Create(ProductCategorieDTO dto);
//         Task Update(int id, ProductCategorieDTO dto);
//         Task Delete(int id);
//     }
// }