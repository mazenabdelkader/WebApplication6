using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness_Logic_Layer.Dtos.Department
{
    public class CreatedDepartmentDTO
    {
        [Required]
        public string Code { get; set; } = null!;

        [Required]
        public string Name { get; set; } = null!;

        public string? Description { get; set; }

        [Display(Name = "Date Of Creation")]
        public DateOnly DateOfCreation { get; set; }
    }
}
