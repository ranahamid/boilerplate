using System.Threading.Tasks;
using Abp.Application.Services;
using Boiler.Authorization.Accounts.Dto;

namespace Boiler.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
