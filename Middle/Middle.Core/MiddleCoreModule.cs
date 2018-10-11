using System.Reflection;
using Abp.Modules;

namespace Middle
{
    public class MiddleCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
