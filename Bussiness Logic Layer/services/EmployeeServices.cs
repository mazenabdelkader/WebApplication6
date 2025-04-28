using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bussiness_Logic_Layer.Dtos.Employee;

namespace Bussiness_Logic_Layer.services
{
    public class EmployeeServices : IEmployeeServices
    {
        public int createemployee(CreatedEmployeeDto employee)
        {
            throw new NotImplementedException();
        }

        public bool deleteemployee(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeDetailsDto> getall(bool withtracking = false)
        {
            throw new NotImplementedException();
        }

        public EmployeeDetailsDto Getbyid(int id)
        {
            throw new NotImplementedException();
        }

        public int Updateemployee(UpdatedEmployeeDto employee)
        {
            throw new NotImplementedException();
        }
    }
}
