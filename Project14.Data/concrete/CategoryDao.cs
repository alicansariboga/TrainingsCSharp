using Project14.Data.@abstract;
using Project14.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project14.Data.concrete
{
    public class CategoryDao : ICategoryDao
    {
        public void Add(Category category)
        {
            using (LogisticContext logisticContext = new LogisticContext())
            {
                logisticContext.Categories.Add(category);
                logisticContext.SaveChanges();
            }
        }

        public void Delete(Category category)
        {
            using (LogisticContext logisticContext = new LogisticContext())
            {
                logisticContext.Categories.Remove(logisticContext.Categories.SingleOrDefault(p => p.CategoryId == category.CategoryId));
                logisticContext.SaveChanges();
            }
        }

        public List<Category> GetAll()
        {
            using (LogisticContext logisticContext = new LogisticContext())
            {
                return logisticContext.Categories.ToList();
            }
        }

        public Category GetById(int id)
        {
            using (LogisticContext logisticContext = new LogisticContext())
            {
                return logisticContext.Categories.SingleOrDefault(p => p.CategoryId == id);
            }
        }

        public void Update(Category category)
        {
            using (LogisticContext logisticContext = new LogisticContext())
            {
                var categoryToUpdate = logisticContext.Categories.SingleOrDefault(p => p.CategoryId == category.CategoryId);

                categoryToUpdate.CategoryName = category.CategoryName;
                categoryToUpdate.Description = category.Description;

                logisticContext.SaveChanges(); //saved
            }
        }
    }
}
