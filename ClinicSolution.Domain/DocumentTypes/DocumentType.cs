using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicSolution.Domain.DocumentTypes
{
    public class DocumentType: Audit, IDocumentType
    {
        public string DocumentName { get; set; }
    }
}
