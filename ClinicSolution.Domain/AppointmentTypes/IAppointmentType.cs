using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicSolution.Domain.AppointmentTypes
{
    public interface IAppointmentType
    {
        Guid Id { get; set; }
        string AppointMentName { get; set; }
        DateTime DateCreated { get; set; }
        DateTime? DateModified { get; set; }
        bool Active { get; set; }
    }
}
