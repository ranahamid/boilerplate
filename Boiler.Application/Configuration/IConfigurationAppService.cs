using System.Threading.Tasks;
using Abp.Application.Services;
using Boiler.Configuration.Dto;

namespace Boiler.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}