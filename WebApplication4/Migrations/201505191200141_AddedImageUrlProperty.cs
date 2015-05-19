namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedImageUrlProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BlogPosts", "ImageUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.BlogPosts", "ImageUrl");
        }
    }
}
