using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using ClinicSolution.Domain.Appointments;
using ClinicSolution.Domain.AppointmentTypes;
using ClinicSolution.Domain.Patients;

namespace ClinicSolution.Persistence
{
    public partial class Context: DbContext
    {
        public Context() : base("ClinicSolutionDb") { }

        public virtual DbSet<AppointmentEntity> Appointments { get; set; }

        public virtual DbSet<PatientEntity> Patients { get; set; }

        public virtual DbSet<AppointmentTypeEntity> AppointmentTypes { get; set; }

    }
}
