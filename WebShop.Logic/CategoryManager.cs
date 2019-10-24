using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Logic
{
    public class CategoryManager
    {
        private List<Category> Categories;
        private int CurrentId;

        public CategoryManager()
        {
            Categories = new List<Category>();
            CurrentId = 100;
        }

        public List<Category> GetAll()
        {
            return Categories;
        }

        public Category Get(int id)
        {
            var category = Categories.Find(c => c.Id == id);

            return category;
        }
        public Category GetCategory(int id)
        {
            var category = Categories.Find(c => c.CategoryId == id);

            return category;
        }
        // STUB data 
        // dummy data
        public void Seed()
        {
            Categories.Add(new Category()
            {
                Id = 1,
                Title = "Electronics"
            });
            Categories.Add(new Category()
            {
                Id = 4,
                Title = "Clothing"
            });

            Categories.Add(new Category()
            {
                Id = 2,
                Title = "Phones",
                CategoryId = 1
            });
            Categories.Add(new Category()
            {
                Id = 3,
                Title = "TV",
                CategoryId = 1
            });
            Categories.Add(new Category()
            {
                Id = 5,
                Title = "Men",
                CategoryId = 4
            });
            Categories.Add(new Category()
            {
                Id = 6,
                Title = "Women",
                CategoryId = 4
            });
            Categories.Add(new Category()
            {
                Id = 7,
                Title = "Kid",
                CategoryId = 4
            });

        }
    }
}
