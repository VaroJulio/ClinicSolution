using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicSolution.Domain.DocumentTypes
{
    public interface IDocumentType
    {
        Guid Id { get; set; }
        string DocumentName { get; set; }
        DateTime DateCreated { get; set; }
        DateTime? DateModified { get; set; }
        bool Active { get; set; }
    }
}
