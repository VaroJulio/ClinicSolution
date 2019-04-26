using AutoMapper;
using ClinicSolution.Domain.Patients;

namespace ClinicSolution.Persistence.Profiles
{
    public class PatientProfile: Profile
    {
        public PatientProfile()
        {
            CreateMap<Patient, PatientEntity>().ReverseMap();
        }
    }
}
