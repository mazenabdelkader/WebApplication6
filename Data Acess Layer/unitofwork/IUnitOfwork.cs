using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Acess_Layer.data.repository.interfaces;

namespace Data_Acess_Layer.unitofwork
{
    public interface IUnitOfwork : IDisposable  
    {
        public IEmployeerepository EmployeeRepository { get; }
        public IDepartmentRepository DepartmentRepository { get; }
        public int SaveChanges();
    }
}
