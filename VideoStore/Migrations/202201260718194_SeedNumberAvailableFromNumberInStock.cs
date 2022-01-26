namespace VideoStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedNumberAvailableFromNumberInStock : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MOVIES SET NumberAvailable = NumberInStock");
        }
        
        public override void Down()
        {
        }
    }
}
