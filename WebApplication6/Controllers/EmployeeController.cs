using Bussiness_Logic_Layer.Dtos.Employee;
using Bussiness_Logic_Layer.services;
using Data_Acess_Layer.data.repository.interfaces;
using Data_Acess_Layer.models.EmployeeModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Presentation_Layer.Controllers
{
    public class EmployeeController(IEmployeeServices employeeservice,IDepartmentServices departmentServices,ILogger<EmployeeController> logger ,IWebHostEnvironment environment) : Controller
    {
        public IActionResult Index()
        {
            var emloyees = employeeservice.getallemployee();
            return View(emloyees);
        }
        [HttpGet]
        public IActionResult create()
        {
            ViewData["Departments"] = departmentServices.getalldepartment();    
            return View();
        }
        [HttpPost]
        public IActionResult create(CreatedEmployeeDto createdemployeedto)
        {


            if (ModelState.IsValid)
            {
                try
                {
                    int result = employeeservice.createemployee(createdemployeedto);
                    if (result > 0)
                    {

                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        ModelState.AddModelError("", "Failed to create employee");
                    }

                }
                catch (Exception ex)
                {
                    if (environment.IsDevelopment())
                    {

                        ModelState.AddModelError(string.Empty, ex.Message);
                    }
                    else
                    {
                        logger.LogError(ex.Message );
                       
                    }
                }
               
            }
            return View(createdemployeedto);
        }
        [HttpGet]
        public IActionResult details(int? id)
        {

            if (id is null) return BadRequest();

            var employee = employeeservice.getallemployee(id.HasValue);
            if (employee is null) return NotFound();

            return View(employee);

        }
        [HttpGet]
        public IActionResult edit(int? id)
        {

            if (!id.HasValue) return BadRequest();

            var employee = employeeservice.Getemployeebyid(id.Value);
            if (employee is null) return NotFound();
            var employeedto = new UpdatedEmployeeDto()
            {

                Name = employee.Name,
                Age = employee.Age,
                Address = employee.Address,
                Email = employee.Email,

                HiringDate = employee.HiringDate,
                IsActive = employee.IsActive,
                PhoneNumber = employee.PhoneNumber,
                Salary = employee.Salary,
                EmployeeType = Enum.Parse<EmployeeType>(employee.EmployeeType),
                Gender = Enum.Parse<Gender>(employee.Gender)

            };
            return View(employeedto);

        }

    }
}
