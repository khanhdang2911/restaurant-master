﻿namespace winform_project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddHoaDon_SanPhamBanphan3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SanPhamBans", "Soluong", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SanPhamBans", "Soluong");
        }
    }
}
