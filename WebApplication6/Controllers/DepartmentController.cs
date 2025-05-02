using AutoMapper;
using Bussiness_Logic_Layer.Dtos.Department;
using Bussiness_Logic_Layer.services.classes;
using Bussiness_Logic_Layer.services.interfaces;
using Microsoft.AspNetCore.Mvc;
using Presentation_Layer.Models.ViewModels.DepartmentViewModel;

namespace Presentation_Layer.Controllers
{
    public class DepartmentController(IDepartmentServices _departmentServices,
        ILogger<DepartmentController> _logger,
        IWebHostEnvironment _environment,
        IMapper _mapper
        ) : Controller

    {
        //private readonly IDepartmentServices _departmentServices = departmentServices;

        [HttpGet]
        public IActionResult Index()
        {
            var departments = _departmentServices.getalldepartment();

            return View(departments);
        }


        #region Create Department
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(DepartmentViewModel departmentVM)
        {

            var message = string.Empty;


            if (!ModelState.IsValid)
            {
                return View(departmentVM);
            }
            try
            {
                // Mapping   DepartmentViewModel ===> CreatedDepartmentDto 
                var departmentToCreated = _mapper.Map<DepartmentViewModel, CreatedDepartmentDTO>(departmentVM);
                departmentToCreated.DateOfCreation = DateOnly.FromDateTime(DateTime.Now);
                var departments = _departmentServices.getalldepartment();
                var Result = _departmentServices.adddepartment(departmentToCreated);


                if (Result > 0)
                {
                    TempData["Message"] = "Department Is Created";
                    return RedirectToAction(nameof(Index));
                }

                else
                {
                    message = "Department not found";
                    TempData["Message"] = message;

                    ModelState.AddModelError(string.Empty, message);
                    return View(departmentVM);


                }
            }
            catch (Exception ex)
            {
                //log exception


                //set message

                if (_environment.IsDevelopment())
                {
                    message = ex.Message;
                    return View(departmentVM);
                }

                else
                {
                    _logger.LogError(ex, ex.Message);

                }

            }

            return View(departmentVM);

        }
        #endregion

        #region Details
        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (id is null) return BadRequest();

            var department = _departmentServices.GetDepratmentdtobyid(id.Value);
            if (department is null) return NotFound();

            return View(department);

        }
        #endregion

        #region Edit Department
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (!id.HasValue) return BadRequest();


            var department = _departmentServices.GetDepratmentdtobyid(id.Value);
            if (department is null) return NotFound();

            var departmentViewModel = new DepartmentViewModel()
            {
                Code = department.Code,
                Name = department.Name,
                DateOfCreation = department.DateOfCreation,
                Description = department.Description
            };

            return View(departmentViewModel);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Edit([FromRoute] int id, DepartmentViewModel departmentViewModel)
        {

            if (ModelState.IsValid)
            {
                try
                {


                    var UpdatedDepartment = new UpdatedDepartmentDto()
                    {
                        Id = id,
                        Name = departmentViewModel.Name,
                        Code = departmentViewModel.Code,
                        Description = departmentViewModel.Description,
                        DateOfCreation = departmentViewModel.DateOfCreation


                    };
                    int Result = _departmentServices.updatedepartment(UpdatedDepartment);
                    if (Result > 0)
                    {
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Department is not Updated");
                    }



                }
                catch (Exception ex)
                {
                    if (_environment.IsDevelopment())
                    {
                        ModelState.AddModelError(string.Empty, ex.Message);

                    }
                    else
                    {
                        _logger.LogError(ex.Message);
                        return View("Error view", ex);
                    }
                }
            }

            return View(departmentViewModel);
        }
        #endregion

        #region Delete

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (!id.HasValue) return BadRequest();

            var departmenr = _departmentServices.GetDepratmentdtobyid(id.Value);
            if (departmenr is null) return NotFound();

            else
            {
                return View(departmenr);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Delete(int id)
        {
            var message = string.Empty;
            if (id == 0) return BadRequest();

            try
            {
                bool Deleted = _departmentServices.deletedepartment(id);
                if (Deleted)
                {
                    return RedirectToAction(nameof(Index));
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                message = _environment.IsDevelopment() ? ex.Message : "An Error Happend";
            }
            ModelState.AddModelError(string.Empty, "Department Not Deleted");
            return View(nameof(Index));
        }

        #endregion

    }
}
