using System.Reflection;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;

namespace Middle
{
    [DependsOn(typeof(AbpWebApiModule), typeof(MiddleApplicationModule))]
    public class MiddleWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(MiddleApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
