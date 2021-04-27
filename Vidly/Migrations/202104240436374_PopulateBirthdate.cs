namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBirthdate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = '1999-12-12' WHERE Customers.Id= 1");
        }
        
        public override void Down()
        {
        }
    }
}
