namespace MovieReview.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MovieReviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ReviewerName = c.String(),
                        ReviewerComments = c.String(nullable: false, maxLength: 200),
                        ReviewerRating = c.Int(nullable: false),
                        MovieId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Movies", t => t.MovieId, cascadeDelete: true)
                .Index(t => t.MovieId);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MovieName = c.String(),
                        DirectorName = c.String(),
                        ReleaseYear = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MovieReviews", "MovieId", "dbo.Movies");
            DropIndex("dbo.MovieReviews", new[] { "MovieId" });
            DropTable("dbo.Movies");
            DropTable("dbo.MovieReviews");
        }
    }
}
