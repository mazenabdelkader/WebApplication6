using Bussiness_Logic_Layer.services;
using Microsoft.AspNetCore.Mvc;

namespace Presentation_Layer.Controllers
{
    public class DepartmentController(IDepartmentServices departmentServices) : Controller

    {
        //private readonly IDepartmentServices _departmentServices = departmentServices;

        public IActionResult Index()
        {
            var department= departmentServices.getalldepartment();
            return View(department);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (!id.HasValue) return BadRequest();
            var departments = departmentServices.GetDepratmentdtobyid(id.Value);
            if (departments is null) return NotFound();
            return View(departments);
        }

    }
}
