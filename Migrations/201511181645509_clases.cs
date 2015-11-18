namespace proyecto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class clases : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Compras",
                c => new
                    {
                        IDcompras = c.Int(nullable: false, identity: true),
                        Idproveedor = c.Int(nullable: false),
                        IdProducto = c.Int(nullable: false),
                        Nombre = c.String(),
                        Cantidad = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IDcompras);
            
            CreateTable(
                "dbo.Proveedors",
                c => new
                    {
                        IDProveedor = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Ciudad = c.String(),
                        Direccion = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.IDProveedor);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Idusu = c.Int(nullable: false, identity: true),
                        NombreUsuario = c.String(),
                        Contraseña = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Idusu);
            
            CreateTable(
                "dbo.ventas",
                c => new
                    {
                        IDventas = c.Int(nullable: false, identity: true),
                        IDProducto = c.Int(nullable: false),
                        cantidad = c.Single(nullable: false),
                        Fecha = c.Int(nullable: false),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.IDventas);
            
            AddColumn("dbo.invens", "NombreProducto", c => c.String());
            AddColumn("dbo.invens", "Categoria", c => c.String());
            AddColumn("dbo.invens", "precio", c => c.Single(nullable: false));
            DropColumn("dbo.invens", "Nombre");
            DropColumn("dbo.invens", "Producto");
        }
        
        public override void Down()
        {
            AddColumn("dbo.invens", "Producto", c => c.String());
            AddColumn("dbo.invens", "Nombre", c => c.String());
            DropColumn("dbo.invens", "precio");
            DropColumn("dbo.invens", "Categoria");
            DropColumn("dbo.invens", "NombreProducto");
            DropTable("dbo.ventas");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Proveedors");
            DropTable("dbo.Compras");
        }
    }
}
