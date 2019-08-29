using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Module.Logic;
using Module.Web.Models;

namespace Module.Web.Controllers
{
    public class HomeController : Controller
    {
        private IRepositories _repository;
        private IMapper mapper;

        public HomeController()
        {
            _repository = new MyRepository();
            mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProductCategoryLogic, ProductCategoryWeb>()).CreateMapper();
        }

        public ActionResult Index()
        {

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ProductCategory()
        {
            ViewBag.Message = "Your contact page.";

            var productLogicList = _repository.GetList();
            var productWebList = mapper.Map<IEnumerable<ProductCategoryLogic>, List<ProductCategoryWeb>>(productLogicList);
            return View(productWebList);
        }
    }
}