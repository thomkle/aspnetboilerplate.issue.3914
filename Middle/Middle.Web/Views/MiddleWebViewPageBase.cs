using Abp.Web.Mvc.Views;

namespace Middle.Web.Views
{
    public abstract class MiddleWebViewPageBase : MiddleWebViewPageBase<dynamic>
    {

    }

    public abstract class MiddleWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected MiddleWebViewPageBase()
        {
            LocalizationSourceName = MiddleConsts.LocalizationSourceName;
        }
    }
}