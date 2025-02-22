﻿namespace winform_project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateHoaDon : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.HoaDons", "tongTien", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.HoaDons", "tongTien");
        }
    }
}
