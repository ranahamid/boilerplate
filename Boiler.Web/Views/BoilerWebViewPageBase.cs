using Abp.Web.Mvc.Views;

namespace Boiler.Web.Views
{
    public abstract class BoilerWebViewPageBase : BoilerWebViewPageBase<dynamic>
    {

    }

    public abstract class BoilerWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected BoilerWebViewPageBase()
        {
            LocalizationSourceName = BoilerConsts.LocalizationSourceName;
        }
    }
}