using AutoMapper;
using ClinicSolution.Persistence.Profiles;

namespace ClinicSolution.Persistence
{
    public static class MappingProfile
    {
        public static MapperConfiguration InitializeAutoMapper()
        {
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AppointmentProfile());
                cfg.AddProfile(new AppointmentTypeProfile());
                cfg.AddProfile(new DocumentTypesProfile());
                cfg.AddProfile(new PatientProfile());
            });

            return config;
        }
    }
}
