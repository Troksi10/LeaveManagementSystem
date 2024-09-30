using AutoMapper;
using LeaveManSystem.Data;
using LeaveManSystem.Models.LeaveTypes;

namespace LeaveManSystem.MappingProfilies
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<LeaveType, LeaveTypeReadOnlyVM>();
            CreateMap<LeaveTypeCreateVM, LeaveType>();
            CreateMap<LeaveTypeEditVM, LeaveType>().ReverseMap();
        }
    }
}
