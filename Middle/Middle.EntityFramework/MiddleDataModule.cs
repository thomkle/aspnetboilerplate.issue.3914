using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using Middle.EntityFramework;

namespace Middle
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(MiddleCoreModule))]
    public class MiddleDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<MiddleDbContext>(null);
        }
    }
}
