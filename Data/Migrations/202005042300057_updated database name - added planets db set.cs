namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateddatabasenameaddedplanetsdbset : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Planets",
                c => new
                    {
                        PlanetId = c.Int(nullable: false, identity: true),
                        PlanetName = c.String(nullable: false),
                        PlanetDescription = c.String(),
                        PlanetClimate = c.String(),
                        HoursPerDay = c.Int(nullable: false),
                        DaysPerYear = c.Int(nullable: false),
                        NumberOfSuns = c.Int(nullable: false),
                        NumberOfMoons = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PlanetId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Planets");
        }
    }
}
