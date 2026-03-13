using Rent.AppService.InterfaceEntities;
using Rent.AppService.InterfacesSecure;
using Rent.AppServiceX.InterfaceEntities;
using Rent.AppServiceX.InterfacesSecure;
using Rent.Services.ImplementEntties;
using Rent.Services.ImplementSecure;
using Rent.ServiceX.ImplementSecure;
using Rent.UnitOfWork.ImplementEntities;
using Rent.UnitOfWork.ImplementSecure;

namespace Aban.AppBack.DependencyInjection
{
    public class UnitOfWorkRegistration
    {
        public static void AddUnitOfWorkRegistration(IServiceCollection services)
        {
            //EntitiesSecurities Software
            services.AddScoped<IAccountServiceX, AccountServiceX>();
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IUsuarioServiceX, UsuarioServiceX>();
            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<IUsuarioRoleServiceX, UsuarioRoleServiceX>();
            services.AddScoped<IUsuarioRoleService, UsuarioRoleService>();

            //Entities
            services.AddScoped<ICountryServiceX, CountryServiceX>();
            services.AddScoped<ICountryService, CountryService>();
            services.AddScoped<IStateServiceX, StateServiceX>();
            services.AddScoped<IStateService, StateService>();
            services.AddScoped<ICityServiceX, CityServiceX>();
            services.AddScoped<ICityService, CityService>();
            services.AddScoped<ICorporationServiceX, CorporationServiceX>();
            services.AddScoped<ICorporationService, CorporationService>();
            services.AddScoped<IManagerServiceX, ManagerServiceX>();
            services.AddScoped<IManagerService, ManagerService>();

        }
    }
}