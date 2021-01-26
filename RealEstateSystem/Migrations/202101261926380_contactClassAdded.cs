namespace RealEstateSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class contactClassAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        SIN = c.Int(nullable: false),
                        FirstName = c.String(nullable: false),
                        MiddleName = c.String(),
                        LastName = c.String(nullable: false),
                        StreetAddress = c.String(nullable: false),
                        Municipality = c.String(nullable: false),
                        Province = c.String(nullable: false),
                        PostalCode = c.String(nullable: false),
                        HomePhoneNumber = c.String(),
                        CellPhoneNumber = c.String(nullable: false),
                        OfficeEmail = c.String(nullable: false),
                        OfficePhoneNumber = c.String(nullable: false),
                        DateOfBirth = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        UserCreatedBy = c.String(nullable: false),
                        DateCreated = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Contacts");
        }
    }
}
