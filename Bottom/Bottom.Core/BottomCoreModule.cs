using System.Reflection;
using Abp.Modules;

namespace Bottom
{
    public class BottomCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
