using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicSolution.Domain.Appointments
{
    public interface IAppointment
    {
        Guid Id { get; set; }
        Guid AppointMentTypeId { get; set; }
        DateTime AppointMentDate { get; set; }
        string PatientDocument { get; set; }
        Guid PatientDocumentTypeId { get; set; }
        DateTime DateCreated { get; set; }
        DateTime? DateModified { get; set; }
        bool Active { get; set; }
    }
}
