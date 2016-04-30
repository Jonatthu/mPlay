namespace Odasoft.mPlay.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 40),
                        Author = c.String(nullable: false),
                        ReleaseDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Genre = c.String(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(nullable: false),
                        Length = c.String(nullable: false),
                        Image = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ShoppingCarts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TotalPrice = c.Single(nullable: false),
                        Active = c.Boolean(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        Name = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Songs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SongName = c.String(nullable: false),
                        SongLength = c.String(nullable: false),
                        AlbumId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Albums", t => t.AlbumId)
                .Index(t => t.AlbumId);
            
            CreateTable(
                "dbo.ShoppingCartAlbum",
                c => new
                    {
                        ShoppingCartRefId = c.Int(nullable: false),
                        AlbumRefId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ShoppingCartRefId, t.AlbumRefId })
                .ForeignKey("dbo.ShoppingCarts", t => t.ShoppingCartRefId, cascadeDelete: true)
                .ForeignKey("dbo.Albums", t => t.AlbumRefId, cascadeDelete: true)
                .Index(t => t.ShoppingCartRefId)
                .Index(t => t.AlbumRefId);
            
            CreateTable(
                "dbo.ShoppingCartMovie",
                c => new
                    {
                        ShoppingCartRefId = c.Int(nullable: false),
                        MovieRefId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ShoppingCartRefId, t.MovieRefId })
                .ForeignKey("dbo.ShoppingCarts", t => t.ShoppingCartRefId, cascadeDelete: true)
                .ForeignKey("dbo.Movies", t => t.MovieRefId, cascadeDelete: true)
                .Index(t => t.ShoppingCartRefId)
                .Index(t => t.MovieRefId);
            
            CreateTable(
                "dbo.Albums",
                c => new
                    {
                        Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Articles", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Articles", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "Id", "dbo.Articles");
            DropForeignKey("dbo.Albums", "Id", "dbo.Articles");
            DropForeignKey("dbo.Songs", "AlbumId", "dbo.Albums");
            DropForeignKey("dbo.ShoppingCarts", "UserId", "dbo.Users");
            DropForeignKey("dbo.ShoppingCartMovie", "MovieRefId", "dbo.Movies");
            DropForeignKey("dbo.ShoppingCartMovie", "ShoppingCartRefId", "dbo.ShoppingCarts");
            DropForeignKey("dbo.ShoppingCartAlbum", "AlbumRefId", "dbo.Albums");
            DropForeignKey("dbo.ShoppingCartAlbum", "ShoppingCartRefId", "dbo.ShoppingCarts");
            DropIndex("dbo.Movies", new[] { "Id" });
            DropIndex("dbo.Albums", new[] { "Id" });
            DropIndex("dbo.ShoppingCartMovie", new[] { "MovieRefId" });
            DropIndex("dbo.ShoppingCartMovie", new[] { "ShoppingCartRefId" });
            DropIndex("dbo.ShoppingCartAlbum", new[] { "AlbumRefId" });
            DropIndex("dbo.ShoppingCartAlbum", new[] { "ShoppingCartRefId" });
            DropIndex("dbo.Songs", new[] { "AlbumId" });
            DropIndex("dbo.ShoppingCarts", new[] { "UserId" });
            DropTable("dbo.Movies");
            DropTable("dbo.Albums");
            DropTable("dbo.ShoppingCartMovie");
            DropTable("dbo.ShoppingCartAlbum");
            DropTable("dbo.Songs");
            DropTable("dbo.Users");
            DropTable("dbo.ShoppingCarts");
            DropTable("dbo.Articles");
        }
    }
}
