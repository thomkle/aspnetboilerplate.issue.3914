using Abp.Web.Mvc.Controllers;

namespace Middle.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class MiddleControllerBase : AbpController
    {
        protected MiddleControllerBase()
        {
            LocalizationSourceName = MiddleConsts.LocalizationSourceName;
        }
    }
}