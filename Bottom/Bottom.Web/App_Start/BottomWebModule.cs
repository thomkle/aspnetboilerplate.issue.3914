using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Abp.Localization;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Json;
using Abp.Localization.Dictionaries.Xml;
using Abp.Modules;
using Abp.Web.Mvc;

namespace Bottom.Web
{
    [DependsOn(
        typeof(AbpWebMvcModule),
        typeof(BottomDataModule), 
        typeof(BottomApplicationModule), 
        typeof(BottomWebApiModule))]
    public class BottomWebModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Add/remove languages for your application
            Configuration.Localization.Languages.Add(new LanguageInfo("en", "English", "famfamfam-flag-england", true));
            Configuration.Localization.Languages.Add(new LanguageInfo("tr", "Türkçe", "famfamfam-flag-tr"));
            Configuration.Localization.Languages.Add(new LanguageInfo("zh-CN", "简体中文", "famfamfam-flag-cn"));
            Configuration.Localization.Languages.Add(new LanguageInfo("ja", "日本語", "famfamfam-flag-jp"));

            var topAssembly = System.Web.Compilation.BuildManager.GetReferencedAssemblies()
                .Cast<Assembly>()
                .FirstOrDefault(a => a.GetName().Name.Equals("Top.Web.Resources.Embedded"));

            var middleAssembly = System.Web.Compilation.BuildManager.GetReferencedAssemblies()
                .Cast<Assembly>()
                .FirstOrDefault(a => a.GetName().Name.Equals("Middle.Web.Resources.Embedded"));

            Configuration.Localization.Sources.Add(
                new DictionaryBasedLocalizationSource(
                    "Top",
                    new JsonEmbeddedFileLocalizationDictionaryProvider(
                        topAssembly,
                        $"{topAssembly.GetName().Name}.Localization.Top"
                    )
                )
            );

            Configuration.Localization.Sources.Extensions.Add(
                new Abp.Localization.Sources.LocalizationSourceExtensionInfo(
                    "Top",
                    new JsonEmbeddedFileLocalizationDictionaryProvider(
                        middleAssembly,
                        $"{middleAssembly.GetName().Name}.Localization.Middle"
                    )
                )
            );

            Configuration.Localization.Sources.Extensions.Add(
                new Abp.Localization.Sources.LocalizationSourceExtensionInfo(
                    "Top",
                    new JsonFileLocalizationDictionaryProvider(
                        HttpContext.Current.Server.MapPath("~/Localization")
                    )
                )
            );

            //Configure navigation/menu
            Configuration.Navigation.Providers.Add<BottomNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
