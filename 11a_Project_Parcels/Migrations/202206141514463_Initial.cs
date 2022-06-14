namespace _11a_Project_Parcels.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Parcels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Weight = c.Double(nullable: false),
                        parcelTypeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ParcelTypes", t => t.parcelTypeID, cascadeDelete: true)
                .Index(t => t.parcelTypeID);
            
            CreateTable(
                "dbo.ParcelTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Parcels", "parcelTypeID", "dbo.ParcelTypes");
            DropIndex("dbo.Parcels", new[] { "parcelTypeID" });
            DropTable("dbo.ParcelTypes");
            DropTable("dbo.Parcels");
        }
    }
}
