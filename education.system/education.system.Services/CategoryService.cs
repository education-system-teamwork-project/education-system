namespace education.system.Services
{
    using Contracts;
    using Data;
    using Data.Models;
    using System.Linq;
    using education.system.Services.Models.Category;
    using AutoMapper.QueryableExtensions;

    public class CategoryService : ICategoryService
    {
        private readonly EducationSystemDbContext db;

        public CategoryService(EducationSystemDbContext db)
        {
            this.db = db;
        }

        public bool Add(string name)
        {
            var category = this.ByName(name);

            if (category != null)
            {
                return false;
            }

            category = new Category { Name = name };

            this.db.Categories.Add(category);
            this.db.SaveChanges();

            return true;
        }

        public bool Exists(int id)
            => this.db.Categories.Find(id) != null;

        public void Edit(int id, string name)
        {
            var category = this.db.Categories.Find(id);

            if (category == null)
            {
                return;
            }

            category.Name = name;
            this.db.SaveChanges();
        }

        public CategoryBaseModel ById(int id)
            => this.db.Categories
                .Where(c => c.Id == id)
                .ProjectTo<CategoryBaseModel>()
                .FirstOrDefault();

        private Category ByName(string name)
            => this.db.Categories.FirstOrDefault(c => c.Name == name);
    }
}
