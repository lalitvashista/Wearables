using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wearables.Database;
using Wearables.Entities;

namespace Wearables.Services
{
    public class CategoriesService
    {
        public Category GetCategory(int ID)
        {
            using (var context = new WContext())
            {
                return context.Categories.Find(ID);
            }
        }
        public List<Category> GetCategories()
        {
            using (var context = new WContext())
            {
                return context.Categories.ToList();
            }
        }
        public void SaveCategory(Category category) 
        {
            using (var context = new WContext()) 
            {
                context.Categories.Add(category);
                context.SaveChanges();
            }
        }

        public void UpdateCategory(Category category)
        {
            using (var context = new WContext())
            {
                context.Entry(category).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteCategory(int ID)
        {
            using (var context = new WContext())
            {
                var category = context.Categories.Find(ID);
                context.Categories.Remove(category);
                context.SaveChanges();
            }
        }
    }
}
