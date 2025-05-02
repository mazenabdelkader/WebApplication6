using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Bussiness_Logic_Layer.Dtos.Employee;
using Bussiness_Logic_Layer.services.attachmentservice;
using Bussiness_Logic_Layer.services.interfaces;
using Data_Acess_Layer.data.repository.classes;
using Data_Acess_Layer.data.repository.interfaces;
using Data_Acess_Layer.models.EmployeeModel;
using Data_Acess_Layer.unitofwork;

namespace Bussiness_Logic_Layer.services.classes
{
    public class EmployeeServices(IUnitOfwork unitOfwork, IMapper autoMapper , IAttachmentService attachmentService) : IEmployeeServices
    {
        public int createemployee(CreatedEmployeeDto employee)
        {
            var Employee = autoMapper.Map<CreatedEmployeeDto, Employee>(employee);
            if (employee.Image is not null)
            {
                Employee.ImageName = attachmentService.Upload(employee.Image, "Images");
            }
            return unitOfwork.EmployeeRepository.add(Employee);
        }

        public bool deleteemployee(int id)
        {
            var employee = unitOfwork.EmployeeRepository.getbyid(id);
            if (employee == null) return false;
            else
            {
                employee.isdeleted = true;
                return unitOfwork.EmployeeRepository.update(employee) > 0 ? true : false;

            }
        }

        public IEnumerable<EmployeeDto> getallemployee(bool withtracking = false)
        {
            var employees = unitOfwork.EmployeeRepository.getall(withtracking);
            var returnedemployee = autoMapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeDto>>(employees);

            //var returnedemployee = employees.Select(e => new EmployeeDto
            //{
            //    Id = e.Id,
            //    Name = e.Name,
            //    Address = e.Address,
            //    Salary = e.Salary,
            //    Email = e.Email,
            //    PhoneNumber = e.PhoneNumber,
            //    IsActive = e.IsActive,
            //    EmployeeType = e.EmployeeType.ToString(),
            //    Gender =e.Gender.ToString(),



            //});
            return returnedemployee;

        }

        public EmployeeDetailsDto Getemployeebyid(int id)
        {
            var employee = unitOfwork.EmployeeRepository.getbyid(id);
            //if( employee == null) return null;

            //else 
            //{

            //var returnedemp = new EmployeeDetailsDto()
            //{
            //    Id = employee.Id,
            //    Name = employee.Name,
            //    Address = employee.Address,
            //    Salary = employee.Salary,   
            //    Email = employee.Email, 
            //    PhoneNumber = employee.PhoneNumber,
            //    IsActive = employee.IsActive,   
            //    Gender =employee.Gender.ToString(),
            //    EmployeeType = employee.EmployeeType.ToString(),
            //    HiringDate = DateOnly.FromDateTime(employee.HiringDate),
            //    CreatedBy=1,
            //    LastModifiedBy=1
            //};
            return employee is null ? null : autoMapper.Map<Employee, EmployeeDetailsDto>(employee);

        }


        public int Updateemployee(UpdatedEmployeeDto employee)
        {
            return unitOfwork.EmployeeRepository.update(autoMapper.Map<UpdatedEmployeeDto, Employee>(employee));
        }
    }
}
