using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using Top.EntityFramework;

namespace Top
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(TopCoreModule))]
    public class TopDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<TopDbContext>(null);
        }
    }
}
