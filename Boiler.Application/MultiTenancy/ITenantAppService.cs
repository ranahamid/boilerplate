using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Boiler.MultiTenancy.Dto;

namespace Boiler.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
