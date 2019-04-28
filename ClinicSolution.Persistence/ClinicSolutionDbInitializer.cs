using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ClinicSolution.Domain.DocumentTypes;
using AutoMapper;
using System.Reflection;
using System.Data.Entity.Infrastructure;
using ClinicSolution.Domain.AppointmentTypes;
using ClinicSolution.Domain.Patients;

namespace ClinicSolution.Persistence
{
    public class ClinicSolutionDbInitializer: CreateDatabaseIfNotExists<ContextDb>
    {
        private readonly IMapper _mapper;
        public  ClinicSolutionDbInitializer(IMapper mapper)
        {
            _mapper = mapper;
        }
        protected override void Seed(ContextDb context)
        {
            try {
                IList<DocumentTypeEntity> DocumentEntityList = new List<DocumentTypeEntity>();
                var cedula = new DocumentType() { DocumentName = "Cedula" };
                var cedulaExtrangeria = new DocumentType() { DocumentName = "Cedula de extranjeria" };
                var tarjetaIdentidad = new DocumentType() { DocumentName = "Tarjeta de Identidad" };
                var registroCivil = new DocumentType() { DocumentName = "Registro civil" };
                DocumentEntityList.Add(_mapper.Map<DocumentTypeEntity>(cedula));
                DocumentEntityList.Add(_mapper.Map<DocumentTypeEntity>(cedulaExtrangeria));
                DocumentEntityList.Add(_mapper.Map<DocumentTypeEntity>(tarjetaIdentidad));
                DocumentEntityList.Add(_mapper.Map<DocumentTypeEntity>(registroCivil));

                context.DocumentTypes.AddRange(DocumentEntityList);
                //context.SaveChanges();

                IList<AppointmentTypeEntity> AppointmentEntityList = new List<AppointmentTypeEntity>();
                var medGen = new AppointmentType() { AppointMentName = "Medeicina General" };
                var odont = new AppointmentType() { AppointMentName = "Odontologia" };
                var ped = new AppointmentType() { AppointMentName = "Pediatria" };
                var neuro = new AppointmentType() { AppointMentName = "Neurologia" };
                AppointmentEntityList.Add(_mapper.Map<AppointmentTypeEntity>(medGen));
                AppointmentEntityList.Add(_mapper.Map<AppointmentTypeEntity>(odont));
                AppointmentEntityList.Add(_mapper.Map<AppointmentTypeEntity>(ped));
                AppointmentEntityList.Add(_mapper.Map<AppointmentTypeEntity>(neuro));

                context.AppointmentTypes.AddRange(AppointmentEntityList);
                //context.SaveChanges();

                IList<PatientEntity> PatientsEntityList = new List<PatientEntity>();
                var patient1 = new Patient() { Document = "1065584866", DocumentTypeId = DocumentEntityList.FirstOrDefault(x => x.DocumentName == "Cedula").Id, FirstName = "Alvaro Jose", LastName = "Julio Beltran", PhoneNumber = "3193745954", Email = "alvarodev@hotmail.com", BirthDay = new DateTime(1987, 7, 7) };
                var patient2 = new Patient() { Document = "10655823840", DocumentTypeId = DocumentEntityList.FirstOrDefault(x => x.DocumentName == "Cedula").Id, FirstName = "Eilen Melissa", LastName = "Beltran Colon", PhoneNumber = "3173745957", Email = "melissa@hotmail.com", BirthDay = new DateTime(1990, 12, 23) };
                var patient3 = new Patient() { Document = "1065584899", DocumentTypeId = DocumentEntityList.FirstOrDefault(x => x.DocumentName == "Cedula").Id, FirstName = "Natali Andre", LastName = "Julio Beltran", PhoneNumber = "3133745959", Email = "natali@hotmail.com", BirthDay = new DateTime(1998, 5, 15) };
                PatientsEntityList.Add(_mapper.Map<PatientEntity>(patient1));
                PatientsEntityList.Add(_mapper.Map<PatientEntity>(patient2));
                PatientsEntityList.Add(_mapper.Map<PatientEntity>(patient3));

                context.Patients.AddRange(PatientsEntityList);
                //context.SaveChanges();
                base.Seed(context);
            }
            catch (Exception ex)
            {
                throw new DbUpdateException("Error con la base de datos: " + ex);
            }
        }
    }
}
