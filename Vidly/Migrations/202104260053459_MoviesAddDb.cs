namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MoviesAddDb : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES " +
                "('Hang Over 3',5, '2012-06-18', '2012-06-18',3)");

            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES " +
                "('Godzilla vs Kong', 1, '2021-03-31', '2021-04-23', 12)");

Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES " +
                "('Titanic', 4, '1997-12-19', '2021-04-25', 12)");

Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES " +
    "('Inception', 1, '2010-07-13', '2021-04-25', 42)");

Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES " +
    "('Pulp Fiction', 1, '1994-10-14', '2021-04-25', 8)");


Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES " +
    "('Fight Club', 1, '1999-10-15', '2021-04-25', 82)");

        }
        
        public override void Down()
        {
        }
    }
}
