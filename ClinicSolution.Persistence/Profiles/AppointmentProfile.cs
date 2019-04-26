using AutoMapper;
using ClinicSolution.Domain.Appointments;

namespace ClinicSolution.Persistence.Profiles
{
    public class AppointmentProfile: Profile
    {
        public AppointmentProfile()
        {
            CreateMap<Appointment, AppointmentEntity>().ReverseMap();
        }
    }
}
