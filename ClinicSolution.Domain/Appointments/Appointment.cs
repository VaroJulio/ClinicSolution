using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicSolution.Domain.Appointments
{
    public class Appointment: Audit, IAppointment
    {
        public Guid AppointMentTypeId { get; set; }
        public DateTime AppointMentDate { get; set; }
        public string PatientDocument { get; set; }
        public Guid PatientDocumentTypeId { get; set; }
    }
}
