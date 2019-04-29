namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DrivingLicense]) VALUES (N'07af3ab0-5536-485c-a12a-924463c8c235', NULL, 0, N'AGBly0+xp3Q7SsAjYOuue2AJozh8HFj2EuZEe7kU5rD/jIhyTnXWi4LZgQBJIqfjqQ==', N'8ec3aa50-4302-4ddd-84b1-2903156f69b7', N'0526264647', 0, 0, NULL, 0, 0, N'raz', N'')
    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DrivingLicense]) VALUES (N'caebcf52-5715-460e-91bf-b5a13f2fba66', NULL, 0, N'AAGIINE2IAwOD+SyUN15dVVYBms9MLlCh18LNKuVTOuNS6xxUzzP5QDNCx7J8M7UXA==', N'68bca2fa-f51b-4042-83c9-41f4ae97d337', N'0524256303', 0, 0, NULL, 0, 0, N'admin', N'')
             
    INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'ea9ff4e3-75c1-425c-8fbc-abf0759d33b5', N'CanManageMovies')

    INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'07af3ab0-5536-485c-a12a-924463c8c235', N'ea9ff4e3-75c1-425c-8fbc-abf0759d33b5')
            
                
                ");


        }
        
        public override void Down()
        {
        }
    }
}
