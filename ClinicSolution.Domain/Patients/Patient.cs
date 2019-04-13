using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicSolution.Domain.Patients
{
    public class Patient: Audit, IPatient
    {
        public String Document { get; set; }
        public Guid DocumentTypeId { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String PhoneNumber { get; set; }
        public String Email { get; set; }
        public DateTime BirthDay { get; set; }
    }
}
