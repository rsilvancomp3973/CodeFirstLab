namespace LabCodeFirst.Migrations.Locations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addforeignkey3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cities", "Province_ProvinceCode", "dbo.Provinces");
            DropIndex("dbo.Cities", new[] { "Province_ProvinceCode" });
            RenameColumn(table: "dbo.Cities", name: "Province_ProvinceCode", newName: "ProvinceCode");
            AlterColumn("dbo.Cities", "ProvinceCode", c => c.Int(nullable: false));
            CreateIndex("dbo.Cities", "ProvinceCode");
            AddForeignKey("dbo.Cities", "ProvinceCode", "dbo.Provinces", "ProvinceCode", cascadeDelete: true);
            DropColumn("dbo.Cities", "ProvinceId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cities", "ProvinceId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Cities", "ProvinceCode", "dbo.Provinces");
            DropIndex("dbo.Cities", new[] { "ProvinceCode" });
            AlterColumn("dbo.Cities", "ProvinceCode", c => c.Int());
            RenameColumn(table: "dbo.Cities", name: "ProvinceCode", newName: "Province_ProvinceCode");
            CreateIndex("dbo.Cities", "Province_ProvinceCode");
            AddForeignKey("dbo.Cities", "Province_ProvinceCode", "dbo.Provinces", "ProvinceCode");
        }
    }
}
