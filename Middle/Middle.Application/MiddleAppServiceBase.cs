using Abp.Application.Services;

namespace Middle
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class MiddleAppServiceBase : ApplicationService
    {
        protected MiddleAppServiceBase()
        {
            LocalizationSourceName = MiddleConsts.LocalizationSourceName;
        }
    }
}