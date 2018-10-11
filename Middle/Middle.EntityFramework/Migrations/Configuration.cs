using System.Data.Entity.Migrations;

namespace Middle.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Middle.EntityFramework.MiddleDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Middle";
        }

        protected override void Seed(Middle.EntityFramework.MiddleDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}
