using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Acess_Layer.data;
using Data_Acess_Layer.data.repository.interfaces;

namespace Data_Acess_Layer.unitofwork
{
    public class UnitOfWork : IUnitOfwork
    {
        private Lazy< IDepartmentRepository> DepartmentRepository;
        private Lazy <IEmployeerepository> employeerepository;
        private readonly AppDBContext _dbContext;

        public UnitOfWork(IEmployeerepository employeerepository,IDepartmentRepository departmentRepository,AppDBContext dbContext)
        {
            _dbContext = dbContext;
            EmployeeRepository = employeerepository;
            DepartmentRepository = departmentRepository;
        }
        public IEmployeerepository EmployeeRepository
        { 
        get
            {
                return employeerepository;
            }
            set
            {
                employeerepository = value;
            }   


        }

        public IDepartmentRepository departmentRepository
        {
            get
            {
                return departmentRepository;
            }
            set
            {
                departmentRepository = value;
            }


        }


        public void Dispose()
        {
            _dbContext.Dispose();   
        }

        public int SaveChanges()
        {
           return _dbContext.SaveChanges(); 
        }
    }
}
