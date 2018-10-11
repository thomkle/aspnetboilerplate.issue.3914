using System.Data.Entity.Migrations;

namespace Bottom.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Bottom.EntityFramework.BottomDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Bottom";
        }

        protected override void Seed(Bottom.EntityFramework.BottomDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}
