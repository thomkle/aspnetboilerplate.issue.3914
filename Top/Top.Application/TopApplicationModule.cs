using System.Reflection;
using Abp.Modules;

namespace Top
{
    [DependsOn(typeof(TopCoreModule))]
    public class TopApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
