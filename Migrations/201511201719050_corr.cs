namespace proyecto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class corr : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ventas", "Fecha");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ventas", "Fecha", c => c.Int(nullable: false));
        }
    }
}
