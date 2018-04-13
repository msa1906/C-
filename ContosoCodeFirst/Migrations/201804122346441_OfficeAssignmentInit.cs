namespace ContosoCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OfficeAssignmentInit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OfficeAssignments",
                c => new
                    {
                        InstructorID = c.Int(nullable: false),
                        Location = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.InstructorID)
                .ForeignKey("dbo.Instructors", t => t.InstructorID)
                .Index(t => t.InstructorID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OfficeAssignments", "InstructorID", "dbo.Instructors");
            DropIndex("dbo.OfficeAssignments", new[] { "InstructorID" });
            DropTable("dbo.OfficeAssignments");
        }
    }
}
