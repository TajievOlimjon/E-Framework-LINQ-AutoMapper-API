using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace WebApIPersistenseProgect.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private CategoryService categoryService;
        public CategoryController(CategoryService categoryService)
        {
            this.categoryService=categoryService;
        }

        [HttpGet("GetCategories")]
        public List<Category> GetCategories()
        {
            return categoryService.GetCategories();
        }

        [HttpGet("GetCategoryById")]
        public Category GetCategoryById(int id)
        {
            return categoryService.GetCategoryById(id);
         }

        [HttpPost("InsertCategory")]
        public int InsertCategory(Category category)
        {
            return categoryService.InsertCategory(category);
        }

        [HttpPut("UpdateCategory")]
        public int UpdateCategory(Category category)
        {
          return  categoryService.UpdateCategory(category);
        }

        [HttpDelete("DeleteCategory")]
        public int DeleteCategory(int id)
        {
            return categoryService.DeleteCategory(id);
        }
    }
}
