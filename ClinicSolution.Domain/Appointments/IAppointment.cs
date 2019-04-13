using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicSolution.Domain.Appointments
{
    public interface IAppointment
    {
        Guid Id { get; set; }
        Guid AppointMentType { get; set; }
        DateTime AppointMentDate { get; set; }
        Guid PatientId { get; set; }
    }
}
