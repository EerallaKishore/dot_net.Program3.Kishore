namespace eClerx.Program3.Kishore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableSuppliers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        SupplierId = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(nullable: false, maxLength: 50),
                        ContactName = c.String(maxLength: 50),
                        Address = c.String(maxLength: 200),
                        City = c.String(maxLength: 50),
                        Pincode = c.String(maxLength: 6),
                        MobileNo = c.String(maxLength: 12),
                        EmailId = c.String(maxLength: 100),
                        CraetedDate = c.DateTime(nullable: false, defaultValueSql: "Getdate()"),
                        Modifieddate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.SupplierId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Suppliers");
        }
    }
}
