namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('Shrek', 'Animation', '2011-05-01', GETDATE(), 5);");
            Sql(@"INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('Wall-E', 'Animation', '2015-03-29', GETDATE(), 1);");
            Sql(@"INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('Johnny English', 'Comedy', '2009-02-14', GETDATE(), 7);");
            Sql(@"INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('Laurence Of Arabia', 'History', '1976-12-03', GETDATE(), 0);");
            Sql(@"INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('Excorcist', 'Horror', '1993-06-06', GETDATE(), 6);");
        }

        public override void Down()
        {
        }
    }
}
