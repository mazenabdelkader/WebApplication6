using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Acess_Layer.data.repository.interfaces;
using Data_Acess_Layer.models.DepartmentModel;
using Microsoft.EntityFrameworkCore;

namespace Data_Acess_Layer.data.repository.classes
{
    public class DepartmentReopistory(AppDBContext appDBContext) : IDepartmentRepository
    {
        private readonly AppDBContext _dbcontext=appDBContext;
        //public DepartmentReopistory(AppDBContext dbcontext)
        //{
        //    _dbcontext = dbcontext;
        //}
        public int add(Department entity)
        {


            _dbcontext.departments.Add(entity);
            return _dbcontext.SaveChanges();
        }

        public int delete(Department entity)
        {
            _dbcontext.Remove(entity);
            return _dbcontext.SaveChanges();
        }

        public IEnumerable<Department> getall(bool withtracking = false)
        {
            if (withtracking)
            {
                return _dbcontext.departments.ToList();
            }
            else
            {
                return _dbcontext.departments.AsNoTracking().ToList();
            }
        }

        public Department getbyid(int id)
        {
            return _dbcontext.departments.Find(id);
        }

        public int update(Department entity)
        {
            _dbcontext.Update(entity);
            return _dbcontext.SaveChanges();
        }
    }
}
