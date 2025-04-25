using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Acess_Layer.models.DepartmentModel;

namespace Data_Acess_Layer.data.repository.interfaces
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> getall(bool withtracking = false);
        Department getbyid(int id);
        int update(Department department);
        int delete(Department department);
        int add(Department department);
    }
}
