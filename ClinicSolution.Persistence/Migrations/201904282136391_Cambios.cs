namespace ClinicSolution.Persistence.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class Cambios : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DocumentTypes", "DocumentName", c => c.String(nullable: false, maxLength: 50,
                annotations: new Dictionary<string, AnnotationValues>
                {
                    { 
                        "IndexDocumentTypeName",
                        new AnnotationValues(oldValue: null, newValue: "IndexAnnotation: { IsUnique: True }")
                    },
                }));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.DocumentTypes", "DocumentName", c => c.String(nullable: false, maxLength: 50,
                annotations: new Dictionary<string, AnnotationValues>
                {
                    { 
                        "IndexDocumentTypeName",
                        new AnnotationValues(oldValue: "IndexAnnotation: { IsUnique: True }", newValue: null)
                    },
                }));
        }
    }
}
