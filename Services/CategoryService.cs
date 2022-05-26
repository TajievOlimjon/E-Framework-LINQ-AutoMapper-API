using Domain.Entities;
using Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CategoryService
    {
       private DataContext dataContext;

        public CategoryService(DataContext dataContext)
        {
            this.dataContext=dataContext;
        }


        public List<Category> GetCategories()
        {
            var books = dataContext.Categories.ToList();
            return books.ToList();
        }

        public Category GetCategoryById(int Id)
        {
            var book=dataContext.Categories.Find(Id);
            return book;

        }

        public int InsertCategory(Category category)
        {
            dataContext.Categories.Add(category);
            var categor = dataContext.SaveChanges();
            return categor;
        }

        public int UpdateCategory(Category category)
        {
            var category1 = dataContext.Categories.Find(category.Id);
            category1.Name = category.Name;
            var c = dataContext.SaveChanges();
            return c;
        }

        public int DeleteCategory(int id)
        {
            var d = dataContext.Categories.Find(id);
            dataContext.Categories.Remove(d);
            var delete = dataContext.SaveChanges();
            return delete;
        }
    }
}
