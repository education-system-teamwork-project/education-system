namespace education.system.App.Areas.Admin.Controllers
{
    using education.system.Services.Contracts;
    using education.system.Services.Models.Category;
    using Microsoft.AspNetCore.Mvc;
    using Models.Category;

    public class CategoriesController : AdminBaseController
    {
        private const string categoryExistsError = "Category with name {0} already exists.";

        private readonly ICategoryService categories;

        public CategoriesController(ICategoryService categories)
        {
            this.categories = categories;
        }

        public IActionResult Add() => View();

        [HttpPost]
        public IActionResult Add(CategoryAddModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var success = this.categories.Add(model.Name);

            if (!success)
            {
                ModelState.AddModelError("", string.Format(categoryExistsError, model.Name));

                return View(model);
            }

            return RedirectToAction(nameof(Add));
        }

        public IActionResult Edit(int id)
        {
            var category = this.categories.ById(id);

            if (category == null)
            {
                return BadRequest();
            }

            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(CategoryBaseModel model)
        {
            var exists = this.categories.Exists(model.Id);

            if (!exists || !ModelState.IsValid)
            {
                return BadRequest();
            }

            this.categories.Edit(model.Id, model.Name);

            return RedirectToAction(nameof(App.Controllers.CategoriesController.All), "Categories");
        }
    }
}
