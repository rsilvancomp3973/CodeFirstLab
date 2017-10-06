namespace LabCodeFirst.Migrations.Locations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addforeignkey2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cities", "ProvinceId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cities", "ProvinceId");
        }
    }
}
