using OnClass.Service.Authentication;
using OnClass.Infra.Repositories;
using OnClass.Infra.Repositories.Interfaces;
using OnClass.Infra.UnitOfWork;
using OnClass.Mapper;
using OnClass.Service.Data;
using OnClass.Service.Data.Interfaces;
using OnClass.Service.Authentication.Interfaces;
using OnClass.Service.FileHelper;
using OnClass.Service.FileHelper.Interfaces;

namespace OnClass.API.Setup
{
    public static class DependencyInjection
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IAulaRepository, AulaRepository>();
            services.AddScoped<IAulaService, AulaService>();

            services.AddScoped<IDisciplinaRepository, DisciplinaRepository>();
            services.AddScoped<IDisciplinaService, DisciplinaService>();

            services.AddScoped<IDocumentoAulaRepository, DocumentoAulaRepository>();

            services.AddScoped<IEstudanteRepository, EstudanteRepository>();

            services.AddScoped<IEstudanteDisciplinaRepository, EstudanteDisciplinaRepository>();

            services.AddScoped<IFrequenciaAulaRepository, FrequenciaAulaRepository>();

            services.AddScoped<IInstrutorRepository, InstrutorRepository>();

            services.AddScoped<IInstrutorDisciplinaRepository, InstrutorDisciplinaRepository>();

            services.AddScoped<IUserRepository, UserRepository>();
            
            services.AddScoped<IAuthenticationService, AuthenticationService>();

            services.AddScoped<IFileHelperService, FileHelperService>();

            services.AddTransient<IUnitOfWork, UnitOfWork>();

            services.AddSingleton(AutoMapperConfig.RegisterAutoMapper());
        }
    }
}
