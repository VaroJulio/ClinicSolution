using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicSolution.Domain.Patients
{
    public class Patient: Audit, IPatient
    {
        public string Document { get; set; }
        public Guid DocumentTypeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime BirthDay { get; set; }
    }
}
