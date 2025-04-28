using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bussiness_Logic_Layer.Dtos.Employee;

namespace Bussiness_Logic_Layer.services
{
    public interface IEmployeeServices
    {
        IEnumerable<EmployeeDto> getallemployee(bool withtracking = false);
        EmployeeDetailsDto Getemployeebyid(int id);
        int createemployee(CreatedEmployeeDto employee);
        int Updateemployee(UpdatedEmployeeDto employee);
        bool deleteemployee(int id);
    }
}
