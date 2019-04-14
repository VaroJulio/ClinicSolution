using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using ClinicSolution.Domain.AppointmentTypes;
using ClinicSolution.Domain.Patients;

namespace ClinicSolution.Domain.Appointments
{
    [Table("Appointments")]
    public class AppointmentEntity: IAppointment
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("AppointmentType")]
        public Guid AppointMentTypeId { get; set; }

        [Required]
        public DateTime AppointMentDate { get; set; }

        [ForeignKey("Patient")]
        public Guid PatientId { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }

        public DateTime? DateModified { get; set; }

        [Required]
        public bool Active { get; set; }

        [Required]
        public virtual AppointmentTypeEntity AppointmentType { get; set; }

        [Required]
        public virtual PatientEntity Patient { get; set; }
    }
}
