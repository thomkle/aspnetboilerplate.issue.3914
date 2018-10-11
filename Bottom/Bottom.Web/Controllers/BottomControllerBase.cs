using Abp.Web.Mvc.Controllers;

namespace Bottom.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class BottomControllerBase : AbpController
    {
        protected BottomControllerBase()
        {
            LocalizationSourceName = BottomConsts.LocalizationSourceName;
        }
    }
}