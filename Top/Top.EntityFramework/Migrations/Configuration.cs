using System.Data.Entity.Migrations;

namespace Top.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Top.EntityFramework.TopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Top";
        }

        protected override void Seed(Top.EntityFramework.TopDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}
