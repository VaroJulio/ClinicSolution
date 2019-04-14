using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using ClinicSolution.Domain.Patients;

namespace ClinicSolution.Domain.DocumentTypes
{
    [Table("DocumentTypes")]
    public class DocumentTypeEntity: IDocumentType
    {
        [Key]
        public Guid Id { get; set; }

        [Required, MaxLength(50)]
        public string DocumentName { get; set; }

        [Required]
        public  DateTime DateCreated { get; set; }

        public DateTime? DateModified { get; set; }

        [Required]
        public bool Active { get; set; }

        public virtual ICollection<PatientEntity> Patients { get; set; }
    }
}
