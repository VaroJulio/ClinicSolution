using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicSolution.Domain.Appointments
{
    public class Appointment: Audit, IAppointment
    {
        public Guid AppointMentType { get; set; }
        public DateTime AppointMentDate { get; set; }
        public Guid PatientId { get; set; }
    }
}
