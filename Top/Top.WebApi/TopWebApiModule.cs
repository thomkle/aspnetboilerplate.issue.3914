using System.Reflection;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;

namespace Top
{
    [DependsOn(typeof(AbpWebApiModule), typeof(TopApplicationModule))]
    public class TopWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(TopApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
