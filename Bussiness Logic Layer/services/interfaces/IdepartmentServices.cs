using Bussiness_Logic_Layer.Dtos.Department;

namespace Bussiness_Logic_Layer.services.interfaces
{
    public interface IDepartmentServices
    {
        int adddepartment(CreatedDepartmentDTO departmentdto);
        bool deletedepartment(int id);
        IEnumerable<DepartmentDto> getalldepartment();
        DepartmentDetailsDto? GetDepratmentdtobyid(int id);
        int updatedepartment(UpdatedDepartmentDto departmentdto);
    }
}