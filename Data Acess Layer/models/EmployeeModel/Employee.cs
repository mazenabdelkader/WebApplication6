using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Acess_Layer.models.DepartmentModel;

namespace Data_Acess_Layer.models.EmployeeModel
{
    public class Employee:BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? Age { get; set; }
        public string? Address { get; set; }
        public decimal Salary { get; set; }
        public bool IsActive { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime HiringDate { get; set; }
        public Gender gender { get; set; }
        public EmployeeType EmployeeType { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int LastModifiedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public int? departmentId { get; set; } // foreign key property {one to many} 
        //navigation property {one }
        public Department department { get; set; }
        public string? ImageName { get; set; }
    }
}
