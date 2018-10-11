using Abp.Web.Mvc.Views;

namespace Top.Web.Views
{
    public abstract class TopWebViewPageBase : TopWebViewPageBase<dynamic>
    {

    }

    public abstract class TopWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected TopWebViewPageBase()
        {
            LocalizationSourceName = TopConsts.LocalizationSourceName;
        }
    }
}