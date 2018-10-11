using System.Reflection;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;

namespace Bottom
{
    [DependsOn(typeof(AbpWebApiModule), typeof(BottomApplicationModule))]
    public class BottomWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(BottomApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
