using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using ClinicSolution.Domain.Appointments;

namespace ClinicSolution.Domain.AppointmentTypes
{
    [Table("AppointmentTypes")]
    public class AppointmentTypeEntity: IAppointmentType
    {
        [Key]
        public Guid Id { get; set; }

        [Required, MaxLength(50)]
        public string AppointMentName { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }

        public DateTime? DateModified { get; set; }

        [Required]
        public bool Active { get; set; }

        public ICollection<AppointmentEntity> Appointments { get; set; }
    }
}
