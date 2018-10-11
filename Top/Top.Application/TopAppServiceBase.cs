using Abp.Application.Services;

namespace Top
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class TopAppServiceBase : ApplicationService
    {
        protected TopAppServiceBase()
        {
            LocalizationSourceName = TopConsts.LocalizationSourceName;
        }
    }
}