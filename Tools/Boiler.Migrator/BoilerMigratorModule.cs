using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Boiler.EntityFramework;

namespace Boiler.Migrator
{
    [DependsOn(typeof(BoilerDataModule))]
    public class BoilerMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<BoilerDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}