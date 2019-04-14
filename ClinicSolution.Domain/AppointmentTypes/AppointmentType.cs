using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicSolution.Domain.AppointmentTypes
{
    public class AppointmentType : Audit, IAppointmentType
    {
        public string AppointMentName { get; set; }
    }
}
