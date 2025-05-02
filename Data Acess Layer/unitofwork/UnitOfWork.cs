using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Acess_Layer.data;
using Data_Acess_Layer.data.repository.classes;
using Data_Acess_Layer.data.repository.interfaces;

namespace Data_Acess_Layer.unitofwork
{
    public class UnitOfWork : IUnitOfwork
    {
        private Lazy<IDepartmentRepository> _DepartmentRepository;
        private Lazy<IEmployeerepository> _employeerepository;
        private readonly AppDBContext _dbContext;

        public UnitOfWork(IEmployeerepository employeerepository, IDepartmentRepository departmentRepository, AppDBContext dbContext)
        {
            _dbContext = dbContext;
            _employeerepository = new Lazy<IEmployeerepository>(() => new EmployeeRepository(dbContext));
            _DepartmentRepository = new Lazy<IDepartmentRepository>(() => new DepartmentReopistory(dbContext));
        }
        public IEmployeerepository EmployeeRepository
        {
            get
            {
                return _employeerepository.Value;
            }



        }

        public IDepartmentRepository DepartmentRepository
        {


            get
            {
                return _DepartmentRepository.Value;
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
