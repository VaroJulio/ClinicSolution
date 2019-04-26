using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicSolution.Domain.Appointments;
using ClinicSolution.Domain.AppointmentTypes;
using ClinicSolution.Domain.DocumentTypes;
using ClinicSolution.Domain.Patients;

namespace ClinicSolution.Persistence
{
    public class ContextDb : DbContext
    {
        public ContextDb() : base("ClinicSolutionDb") { }

        public virtual DbSet<AppointmentEntity> Appointments { get; set; }

        public virtual DbSet<PatientEntity> Patients { get; set; }

        public virtual DbSet<AppointmentTypeEntity> AppointmentTypes { get; set; }

        public virtual DbSet<DocumentTypeEntity> DocumentTypes { get; set; }

    }
}
