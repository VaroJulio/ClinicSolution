using AutoMapper;
using ClinicSolution.Domain.DocumentTypes;

namespace ClinicSolution.Persistence.Profiles
{
    public class DocumentTypesProfile: Profile
    {
        public DocumentTypesProfile()
        {
            CreateMap<DocumentType, DocumentTypeEntity>().ReverseMap();
        }
    }
}
