using MedicalSystem.ApplicationCore.Services;
using MedicalSystem.Infrastructure.Repository.Interfaces;
using MedicalSystem.Infrastructure.Repository.Repositories;

namespace MedicalSystemWeb.Configuration
{
	public static class ConfigureScopeServices
	{
		public static IServiceCollection ConfigureScopedServices(this IServiceCollection services)
		{
			services.AddScoped<IUnitOfService, UnitOfService>();
			services.AddScoped<IUnitOfWork, UnitOfWork>();
			
			return services;
		}
	}
}
