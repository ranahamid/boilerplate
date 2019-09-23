using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Boiler.Configuration.Dto;

namespace Boiler.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : BoilerAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
