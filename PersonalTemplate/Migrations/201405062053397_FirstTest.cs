namespace PersonalTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstTest : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bank",
                c => new
                    {
                        BankId = c.Int(nullable: false, identity: true),
                        Naam = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.BankId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Bank");
        }
    }
}
