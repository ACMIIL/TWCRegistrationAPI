using Microsoft.AspNetCore.Http.Extensions;
using TWCRegistration.Business;
using TWCRegistration.Data.Repository;
using TWCRegistration.Service;
using TWCRegistration.Core;
using TWCRegistration.Core.Helper;
using TWCRegistration.Data;

namespace TWCRegistration.API.Configurations
{
    public static class ServicesConfiguration
    {
        public static void AddRegistrationApiServices(this IServiceCollection services) 
        {

            #region DigioAPI
            services.AddTransient<INomineeManager, NomineeManager>();
            services.AddTransient<INomineeService, NomineeService>();
            services.AddTransient<INomineeRepository, NomineeRepository>();
            #endregion

            #region Helper
            services.AddTransient<IHelper, Helper>();
            #endregion


            #region Database
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
            #endregion
        }
    }
}
