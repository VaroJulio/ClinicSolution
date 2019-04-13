using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicSolution.Domain.Patients
{
    public interface IPatient
    {
        Guid Id { get; set; }
        String Document { get; set; }
        Guid DocumentTypeId { get; set; }
        String FirstName { get; set; }
        String LastName { get; set; }
        String PhoneNumber { get; set; }
        String Email { get; set; }
        DateTime BirthDay { get; set; }

    }
}
