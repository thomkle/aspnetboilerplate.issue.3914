using System.Reflection;
using Abp.Modules;

namespace Middle
{
    [DependsOn(typeof(MiddleCoreModule))]
    public class MiddleApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
