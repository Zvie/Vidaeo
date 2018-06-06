namespace Vidaeo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers1 : DbMigration
    {
        public override void Up()
        {
            Sql(@"  INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7a989016-45c1-4539-9313-56aa7b2f216f', N'admin@vidaeo.com', 0, N'AI2xYH+aWJU1UsvDG81beJ/H/ABnWBMsjoPfVSIj4JOJvALUdD1DtLzAm0Vdg/U4wQ==', N'ea6f5d9f-65fa-4c66-a666-e7ecdd082905', NULL, 0, 0, NULL, 1, 0, N'admin@vidaeo.com')
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd1582bfc-722a-472a-b9eb-29e43f166209', N'guest@vidaeo.com', 0, N'AAouLvIW1GkCQIfpYYqVeYrCEnL7kFCe8lhBUAmrZlWyeBKuKHDuHmbUKeUK8exVcw==', N'b00a8d53-44f0-4728-af18-4bfd5fcc49d9', NULL, 0, 0, NULL, 1, 0, N'guest@vidaeo.com')
                    INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'30be6979-db0f-4338-b5e5-0d2da7131746', N'CanManageMovies')
                    INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'7a989016-45c1-4539-9313-56aa7b2f216f', N'30be6979-db0f-4338-b5e5-0d2da7131746')
                ");
        }
        
        public override void Down()
        {
        }
    }
}
