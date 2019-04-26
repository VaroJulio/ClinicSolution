namespace ClinicSolution.Persistence.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class AppointMentAndPatientChanges : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        PatientDocument = c.String(nullable: false, maxLength: 50),
                        PatientDocumentTypeId = c.Guid(nullable: false),
                        Id = c.Guid(nullable: false),
                        AppointMentTypeId = c.Guid(nullable: false),
                        AppointMentDate = c.DateTime(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateModified = c.DateTime(),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AppointmentTypes", t => t.AppointMentTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Patients", t => new { t.PatientDocument, t.PatientDocumentTypeId }, cascadeDelete: true)
                .Index(t => new { t.PatientDocument, t.PatientDocumentTypeId })
                .Index(t => t.AppointMentTypeId);
            
            CreateTable(
                "dbo.AppointmentTypes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        AppointMentName = c.String(nullable: false, maxLength: 50),
                        DateCreated = c.DateTime(nullable: false),
                        DateModified = c.DateTime(),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        Document = c.String(nullable: false, maxLength: 50),
                        DocumentTypeId = c.Guid(nullable: false),
                        Id = c.Guid(nullable: false,
                            annotations: new Dictionary<string, AnnotationValues>
                            {
                                { 
                                    "IndexPatientId",
                                    new AnnotationValues(oldValue: null, newValue: "IndexAnnotation: { IsUnique: True }")
                                },
                            }),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        PhoneNumber = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        BirthDay = c.DateTime(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateModified = c.DateTime(),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => new { t.Document, t.DocumentTypeId })
                .ForeignKey("dbo.DocumentTypes", t => t.DocumentTypeId, cascadeDelete: true)
                .Index(t => t.DocumentTypeId);
            
            CreateTable(
                "dbo.DocumentTypes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        DocumentName = c.String(nullable: false, maxLength: 50),
                        DateCreated = c.DateTime(nullable: false),
                        DateModified = c.DateTime(),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Appointments", new[] { "PatientDocument", "PatientDocumentTypeId" }, "dbo.Patients");
            DropForeignKey("dbo.Patients", "DocumentTypeId", "dbo.DocumentTypes");
            DropForeignKey("dbo.Appointments", "AppointMentTypeId", "dbo.AppointmentTypes");
            DropIndex("dbo.Patients", new[] { "DocumentTypeId" });
            DropIndex("dbo.Appointments", new[] { "AppointMentTypeId" });
            DropIndex("dbo.Appointments", new[] { "PatientDocument", "PatientDocumentTypeId" });
            DropTable("dbo.DocumentTypes");
            DropTable("dbo.Patients",
                removedColumnAnnotations: new Dictionary<string, IDictionary<string, object>>
                {
                    {
                        "Id",
                        new Dictionary<string, object>
                        {
                            { "IndexPatientId", "IndexAnnotation: { IsUnique: True }" },
                        }
                    },
                });
            DropTable("dbo.AppointmentTypes");
            DropTable("dbo.Appointments");
        }
    }
}
