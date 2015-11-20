namespace proyecto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class correcion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ventasinvens",
                c => new
                    {
                        ventas_IDventas = c.Int(nullable: false),
                        inven_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ventas_IDventas, t.inven_Id })
                .ForeignKey("dbo.ventas", t => t.ventas_IDventas, cascadeDelete: true)
                .ForeignKey("dbo.invens", t => t.inven_Id, cascadeDelete: true)
                .Index(t => t.ventas_IDventas)
                .Index(t => t.inven_Id);
            
            AlterColumn("dbo.Proveedors", "Direccion", c => c.String());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ventasinvens", "inven_Id", "dbo.invens");
            DropForeignKey("dbo.ventasinvens", "ventas_IDventas", "dbo.ventas");
            DropIndex("dbo.ventasinvens", new[] { "inven_Id" });
            DropIndex("dbo.ventasinvens", new[] { "ventas_IDventas" });
            AlterColumn("dbo.Proveedors", "Direccion", c => c.Single(nullable: false));
            DropTable("dbo.ventasinvens");
        }
    }
}
