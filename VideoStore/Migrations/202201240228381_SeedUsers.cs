namespace VideoStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b0e4e061-d163-4e72-9254-b89f3f223581', N'erin@domain.com', 0, N'AEhKnvN6aoiIOR0UrZ5/t4a/f5NvT6OcvH+rEzRVqK9sB/Ms6Jk07RycmC4gh3paEg==', N'12355d76-42da-42b3-a960-0f249af43762', NULL, 0, 0, NULL, 1, 0, N'erin@domain.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f93070d0-b416-4cbd-9b13-aac83171e75e', N'admin@videostore.com', 0, N'ADnGf7yLk5hB2qA10jvyZP2jo5I99ss9WklaUJ8U/P4ZVqH478WqcQqNXfHIk1DzIg==', N'b489aae4-5d56-48cd-875e-4f771a0d3f3b', NULL, 0, 0, NULL, 1, 0, N'admin@videostore.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'c98a4e91-dca1-41f6-b417-86f76db2434b', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'f93070d0-b416-4cbd-9b13-aac83171e75e', N'c98a4e91-dca1-41f6-b417-86f76db2434b')
");
        }

    public override void Down()
        {
        }
    }
}
