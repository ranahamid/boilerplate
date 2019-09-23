using Boiler.EntityFramework;
using EntityFramework.DynamicFilters;

namespace Boiler.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly BoilerDbContext _context;

        public InitialHostDbBuilder(BoilerDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
