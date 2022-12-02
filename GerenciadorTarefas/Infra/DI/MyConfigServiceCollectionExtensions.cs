using GerenciadorTarefas.Data.Repositories.Task;
using GerenciadorTarefas.Data.Repositories.User;
using GerenciadorTarefas.Domain.Contracts.Task;
using GerenciadorTarefas.Domain.Contracts.User;
using GerenciadorTarefas.Domain.Services;

namespace GerenciadorTarefas.Infra.DI
{
    public static class MyConfigServiceCollectionExtensions
    {
        public static IServiceCollection AddMyDependencyGroup(this IServiceCollection services)
        {
            services.AddScoped<ITaskRepository, TaskRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ITaskService, TaskService>();
            services.AddScoped<IUserService, UserService>();

            return services;
        }
    }
}
