using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using ClinicSolution.Domain.Appointments;
using ClinicSolution.Domain.DocumentTypes;

namespace ClinicSolution.Domain.Patients
{
    [Table("Patients")]
    public class PatientEntity: IPatient
    {
        [Key]
        public Guid Id { get; set; }

        [Required, MaxLength(50)]
        public string Document { get; set; }

        [ForeignKey("DocumentType")]
        public Guid DocumentTypeId { get; set; }

        [Required, MaxLength(50)]
        public string FirstName { get; set; }

        [Required, MaxLength(50)]
        public string LastName { get; set; }

        [Required, MaxLength(50)]
        public string PhoneNumber { get; set; }

        [Required, MaxLength(50)]
        public string Email { get; set; }

        [Required]
        public DateTime BirthDay { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }

        public DateTime? DateModified { get; set; }

        [Required]
        public bool Active { get; set; }

        [Required]
        public virtual DocumentTypeEntity DocumentType { get; set; }

        public ICollection<AppointmentEntity> Appointments { get; set; }
    }
}
