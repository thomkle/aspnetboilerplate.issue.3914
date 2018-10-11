using Abp.Application.Services;

namespace Bottom
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class BottomAppServiceBase : ApplicationService
    {
        protected BottomAppServiceBase()
        {
            LocalizationSourceName = BottomConsts.LocalizationSourceName;
        }
    }
}