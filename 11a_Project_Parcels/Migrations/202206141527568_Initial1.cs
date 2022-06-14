namespace _11a_Project_Parcels.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Parcels", "parcelTypeID", "dbo.ParcelTypes");
            DropIndex("dbo.Parcels", new[] { "parcelTypeID" });
            RenameColumn(table: "dbo.Parcels", name: "parcelTypeID", newName: "ParcelType_Id");
            AddColumn("dbo.Parcels", "parcelType", c => c.String());
            AlterColumn("dbo.Parcels", "ParcelType_Id", c => c.Int());
            CreateIndex("dbo.Parcels", "ParcelType_Id");
            AddForeignKey("dbo.Parcels", "ParcelType_Id", "dbo.ParcelTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Parcels", "ParcelType_Id", "dbo.ParcelTypes");
            DropIndex("dbo.Parcels", new[] { "ParcelType_Id" });
            AlterColumn("dbo.Parcels", "ParcelType_Id", c => c.Int(nullable: false));
            DropColumn("dbo.Parcels", "parcelType");
            RenameColumn(table: "dbo.Parcels", name: "ParcelType_Id", newName: "parcelTypeID");
            CreateIndex("dbo.Parcels", "parcelTypeID");
            AddForeignKey("dbo.Parcels", "parcelTypeID", "dbo.ParcelTypes", "Id", cascadeDelete: true);
        }
    }
}
