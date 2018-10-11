using System.Reflection;
using Abp.Modules;

namespace Bottom
{
    [DependsOn(typeof(BottomCoreModule))]
    public class BottomApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
