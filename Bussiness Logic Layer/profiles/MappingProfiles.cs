using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Bussiness_Logic_Layer.Dtos.Employee;
using Data_Acess_Layer.models.EmployeeModel;

namespace Bussiness_Logic_Layer.profiles
{
    public class MappingProfiles:Profile
    {
        public MappingProfiles()
        {

            CreateMap<Employee, EmployeeDto>()
                .ForMember(dest => dest.Gender, options => options.MapFrom(src => src.gender))
                .ForMember(dest => dest.emptype, options => options.MapFrom(src => src.EmployeeType));

            CreateMap<Employee, EmployeeDetailsDto>()
            .ForMember(dest => dest.Gender, options => options.MapFrom(src => src.gender))
                .ForMember(dest => dest.EmployeeType, options => options.MapFrom(src => src.EmployeeType))
                .ForMember(dest => dest.HiringDate, options => options.MapFrom(src => DateOnly.FromDateTime(src.HiringDate)));
            CreateMap<Employee, CreatedEmployeeDto>();
                //.ForMember(dest => dest.HiringDate, opt => opt.MapFrom(src => src.HiringDate.TimeOnly.MinValue)));
            CreateMap<Employee, UpdatedEmployeeDto>(); 
            
        }

    }
}
