using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bussiness_Logic_Layer.Dtos.Department;
using Bussiness_Logic_Layer.Factories;
using Bussiness_Logic_Layer.services.interfaces;
using Data_Acess_Layer.data.repository.interfaces;

namespace Bussiness_Logic_Layer.services.classes
{
    public class DepartmentServices(IDepartmentRepository _departmentrepository) : IDepartmentServices
    {

        public IEnumerable<DepartmentDto> getalldepartment()
        {
            //1-manuel Mapping
            var department = _departmentrepository.getall();
            //var departmentnoreturn = department.Select(d => new Departmentdto()
            //{
            //    id = d.id,
            //    Name = d.Name,
            //    code = d.code,
            //   DateOfCreation=DateOnly.FromDateTime(d.createdon.Value),



            //});
            //return departmentnoreturn;
            //2-using extension method
            return department.Select(d => d.ToDepartmentdto());

        }

        public DepartmentDetailsDto? GetDepratmentdtobyid(int id)
        {
            var department = _departmentrepository.getbyid(id);
            if (department is null) return null;
            else
            {
                return department is null ? null : department.ToDepartmentDetailsDto();
            }
            //{ 
            //    return department is null ? null : new DepartmentDetailsDto(department)
            //    {
            //        //Id = department.id,
            //        //Name = department.Name,
            //        //Code = department.code,
            //        //Description = department.Description,
            //        //CreatedBy = department.createdby,
            //        //CreatedOn = DateOnly.FromDateTime(department.createdon.Value),
            //        //LastModifiedBy = department.lastmodifiedby,

            //        //ISDeleted = department.isdeleted
            //    };
        }
        public int adddepartment(CreatedDepartmentDTO departmentdto)
        {
            var department = departmentdto.toEntity();
            return _departmentrepository.add(department);

        }
        public int updatedepartment(UpdatedDepartmentDto departmentdto)
        {

            return _departmentrepository.update(departmentdto.toEntity());
        }
        public int deletedepartment(int id)
        {
            var department = _departmentrepository.getbyid(id);
            if (department is null) return 0;
            else
            {
                int result = _departmentrepository.delete(department);
                return result > 0 ? 1 : 0;


            }

        }
    }
}
