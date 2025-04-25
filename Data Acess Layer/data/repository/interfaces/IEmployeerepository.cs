using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Acess_Layer.models.EmployeeModel;

namespace Data_Acess_Layer.data.repository.interfaces
{
    public interface IEmployeerepository
    {
        IQueryable<Employee> getemployeeByaddress(string address);
        
    }
}
