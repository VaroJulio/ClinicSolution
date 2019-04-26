using AutoMapper;
using ClinicSolution.Domain.AppointmentTypes;

namespace ClinicSolution.Persistence.Profiles
{
    public class AppointmentTypeProfile: Profile
    {
        public AppointmentTypeProfile()
        {
            CreateMap<AppointmentType, AppointmentTypeEntity>().ReverseMap();
        }
    }
}
