using System.Linq;
using Boiler.EntityFramework;
using Boiler.MultiTenancy;

namespace Boiler.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly BoilerDbContext _context;

        public DefaultTenantCreator(BoilerDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
