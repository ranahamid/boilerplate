using System.Threading.Tasks;
using Abp.Application.Services;
using Boiler.Sessions.Dto;

namespace Boiler.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
