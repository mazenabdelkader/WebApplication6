using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness_Logic_Layer.Dtos.Department
{
    public class DepartmentDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string code { get; set; }
        public int id { get; set; }

        public DateOnly DateOfCreation { get; set; }
    }
}
