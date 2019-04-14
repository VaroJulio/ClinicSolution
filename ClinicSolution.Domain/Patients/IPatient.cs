using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicSolution.Domain.Patients
{
    public interface IPatient
    {
        Guid Id { get; set; }
        string Document { get; set; }
        Guid DocumentTypeId { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string PhoneNumber { get; set; }
        string Email { get; set; }
        DateTime BirthDay { get; set; }
    }
}
