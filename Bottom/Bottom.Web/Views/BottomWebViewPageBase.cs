using Abp.Web.Mvc.Views;

namespace Bottom.Web.Views
{
    public abstract class BottomWebViewPageBase : BottomWebViewPageBase<dynamic>
    {

    }

    public abstract class BottomWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected BottomWebViewPageBase()
        {
            LocalizationSourceName = BottomConsts.LocalizationSourceName;
        }
    }
}