namespace ContosoCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Rolepersonjoin : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RolePeopleJoin",
                c => new
                    {
                        Role_ID = c.Int(nullable: false),
                        Person_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Role_ID, t.Person_ID })
                .ForeignKey("dbo.Roles", t => t.Role_ID, cascadeDelete: true)
                .ForeignKey("dbo.People", t => t.Person_ID, cascadeDelete: true)
                .Index(t => t.Role_ID)
                .Index(t => t.Person_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RolePersons", "Person_ID", "dbo.People");
            DropForeignKey("dbo.RolePersons", "Role_ID", "dbo.Roles");
            DropIndex("dbo.RolePersons", new[] { "Person_ID" });
            DropIndex("dbo.RolePersons", new[] { "Role_ID" });
            DropTable("dbo.RolePersons");
        }
    }
}
