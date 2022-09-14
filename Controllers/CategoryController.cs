using AutoMapper;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using PPShowcase.Data.Entity;
using PPShowcase.Data.Repository;
using PPShowcase.Models;

namespace PPShowcase.Controllers
{
    public class CategoryController : Controller
    {

        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;

        public CategoryController(IRepositoryWrapper repositoryWrapper, IMapper mapper)
        {
            this._repository = repositoryWrapper;
            this._mapper = mapper;
        }
        // GET: CategoryController
        public ActionResult Index()
        {
            var categoriList = _repository.Category.FindAll().ToList();
            var model = _mapper.Map<List<CategoryDto>>(categoriList);
            return View(model);
        }

        // GET: CategoryController/Details/5
        public ActionResult Details(int id)
        {
            try
            {
                var entity = _repository.Category.FindByCondition(x => x.Id == id).First();
                return View(_mapper.Map<CategoryDto>(entity));
            }
            catch (Exception e)
            {

                return RedirectToAction(actionName: "Error", controllerName: "Home");
            }
        }

        // GET: CategoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                collection.TryGetValue("Name", out var name);
                collection.TryGetValue("Description", out var description);

                Category entity = new Category()
                {
                    CreationTime = DateTime.Now,
                    Name = name,
                    Description = description
                };
                _repository.Category.Create(entity);
                _repository.Save();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                var entity = _repository.Category.FindByCondition(x => x.Id == id).First();
                return View(_mapper.Map<CategoryDto>(entity));
            }
            catch (Exception e)
            {

                return RedirectToAction(actionName: "Error", controllerName: "Home");
            }
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                if (!ModelState.IsValid) return View();
                //var id = Convert.ToInt32(collection["Id"]);
                var entity = _repository.Category.FindByCondition(x => x.Id == id).First();
                entity.Name = collection["Name"];
                entity.Description = collection["Description"];
                entity.LastModificationTime = DateTime.Now;
                _repository.Category.Update(entity);
                _repository.Save();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
