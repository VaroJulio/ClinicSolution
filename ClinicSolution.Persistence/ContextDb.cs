using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Annotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicSolution.Domain.Appointments;
using ClinicSolution.Domain.AppointmentTypes;
using ClinicSolution.Domain.DocumentTypes;
using ClinicSolution.Domain.Patients;
using ClinicSolution.Persistence.Migrations;
using ClinicSolution.Persistence;
using AutoMapper;

namespace ClinicSolution.Persistence
{
    public class ContextDb : DbContext
    {
        public ContextDb(IMapper mapper) : base("ClinicSolutionDb") {
            Database.SetInitializer(new ClinicSolutionDbInitializer(mapper));
        }

        public virtual DbSet<AppointmentEntity> Appointments { get; set; }

        public virtual DbSet<PatientEntity> Patients { get; set; }

        public virtual DbSet<AppointmentTypeEntity> AppointmentTypes { get; set; }

        public virtual DbSet<DocumentTypeEntity> DocumentTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PatientEntity>()
            .Property(p => p.Id)
            .HasColumnAnnotation("IndexPatientId", new IndexAnnotation(new IndexAttribute() { IsUnique = true }));

            modelBuilder.Entity<DocumentTypeEntity>()
           .Property(p => p.DocumentName)
           .HasColumnAnnotation("IndexDocumentTypeName", new IndexAnnotation(new IndexAttribute() { IsUnique = true }));
        }


    }
}
