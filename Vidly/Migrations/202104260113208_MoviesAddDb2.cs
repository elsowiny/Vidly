namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MoviesAddDb2 : DbMigration
    {
        public override void Up()
        {


            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES " +
                "('Sausage Party', 1, '1999-10-15', '2021-04-25', 8)");

        }
        
        public override void Down()
        {
        }
    }
}
