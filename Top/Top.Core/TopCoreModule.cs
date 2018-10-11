using System.Reflection;
using Abp.Modules;

namespace Top
{
    public class TopCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
