using Abp.Web.Mvc.Controllers;

namespace Top.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class TopControllerBase : AbpController
    {
        protected TopControllerBase()
        {
            LocalizationSourceName = TopConsts.LocalizationSourceName;
        }
    }
}