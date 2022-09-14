using AutoMapper;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

using PPShowcase.Data.Entity;
using PPShowcase.Data.Repository;
using PPShowcase.Models;

namespace PPShowcase.Controllers
{
    public class ProductController : Controller
    {
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;

        public ProductController(IRepositoryWrapper repositoryWrapper,IMapper mapper)
        {
            this._repository = repositoryWrapper;
            this._mapper = mapper;
        }
        // GET: ProductController
        [HttpGet]
        public ActionResult Index()
        {
            var productList = _repository.Product.GetAllWithCategory(x => x.Category).ToList();
            var model = _mapper.Map<List<ProductDto>>(productList);
            return View(model);
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            List<SelectListItem> items = _repository.Category
                .FindAll()
                .Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() })
                .ToList();
            items.Insert(0, new SelectListItem { Text = "Select Category", Value = "0" });
            ViewBag.CategoryItems = items;
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                DateTime.TryParse(collection["ManufacturingDate"], out DateTime manufacturingDate);
                var isActive = Convert.ToBoolean(collection["IsActive"].ToString().Split(',').First());
                Product entity = new Product()
                {
                    CreationTime = DateTime.Now,
                    Name = collection["Name"],
                    Code = collection["Code"],
                    UnitPrice = Convert.ToDecimal(collection["UnitPrice"]),
                    ManufacturingDate = manufacturingDate,
                    IsActive = isActive,
                    CategoryId = Convert.ToInt32( collection["CategoryId"])
                };
                _repository.Product.Create(entity);
                _repository.Save();
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductController/Delete/5
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
