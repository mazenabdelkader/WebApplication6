using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Acess_Layer.models.EmployeeModel;

namespace Data_Acess_Layer.models.DepartmentModel
{
    public class Department : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string code { get; set; }
        public virtual ICollection<Employee> Employeess { get; set; } = new HashSet<Employee>();

    }
}
