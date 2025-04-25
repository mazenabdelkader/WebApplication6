using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bussiness_Logic_Layer.Dtos.Department;
using Data_Acess_Layer.models.DepartmentModel;

namespace Bussiness_Logic_Layer.Factories
{
    static public class DepartmentFactory
    {
        public static DepartmentDto ToDepartmentdto(this Department d)
        {

            return new DepartmentDto()
            {
                Name = d.Name,
                Description = d.Description,
                code = d.code,
                id = d.id,
                DateOfCreation = DateOnly.FromDateTime(d.createdon.Value)
            };


        }
        public static DepartmentDetailsDto ToDepartmentDetailsDto(this Department d)
        {
            return new DepartmentDetailsDto()
            {
                Id = d.id,
                Name = d.Name,
                Code = d.code,
                Description = d.Description,
                CreatedBy = d.createdby,
                CreatedOn = DateOnly.FromDateTime(d.createdon.Value),
                LastModifiedBy = d.lastmodifiedby,
                LastModifiedOn = d.lastmodifiedon.Value,
                ISDeleted = d.isdeleted
            };

        }
        public static Department toEntity(this CreatedDepartmentDTO departmentdto)
        {
            return new Department()
            {
                Name = departmentdto.Name,
                Description = departmentdto.Description,
                code = departmentdto.Code,

                createdon = departmentdto.DateOfCreation.ToDateTime(new TimeOnly()),
            };
        }
        public static Department toEntity(this UpdatedDepartmentDto departmentdto)
        {
            return new Department()
            {

                Name = departmentdto.Name,
                Description = departmentdto.Description,
                code = departmentdto.Code,

                createdon = departmentdto.DateOfCreation.ToDateTime(new TimeOnly()),
            };
        }

    }
}
