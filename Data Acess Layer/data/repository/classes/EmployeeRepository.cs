using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Acess_Layer.data.repository.interfaces;
using Data_Acess_Layer.models.EmployeeModel;

namespace Data_Acess_Layer.data.repository.classes
{
    public class EmployeeRepository(AppDBContext context) : GenericRepository<Employee>(context), IEmployeerepository
    {
        public IQueryable<Employee> getemployeeByaddress(string address)
        {
            throw new NotImplementedException();
        }
    }
}
