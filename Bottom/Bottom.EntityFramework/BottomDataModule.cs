using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using Bottom.EntityFramework;

namespace Bottom
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(BottomCoreModule))]
    public class BottomDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<BottomDbContext>(null);
        }
    }
}
