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
        private readonly AppDBContext _dbContext;

        public UnitOfWork(AppDBContext dbContext)
        {
            _dbContext = dbContext;
            //EmployeeRepository=new EmployeeRepository(_dbContext);
            //DepartmentRepository = new DepartmentRepository(_dbContext);

        }
        public IEmployeerepository EmployeeRepository => throw new NotImplementedException();

        public IDepartmentRepository DepartmentRepository => throw new NotImplementedException();

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
