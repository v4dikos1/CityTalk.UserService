﻿using Mapster;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Application
{
    public static class ServiceRegistrar
    {
        public static IServiceCollection RegisterUseCasesService(this IServiceCollection services)
        {
            services.AddMediatR(configuration => configuration.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            services.RegisterMapsterAutogeneratedMappingClasses(Assembly.GetExecutingAssembly());

            return services;
        }

        private static IServiceCollection RegisterMapsterAutogeneratedMappingClasses(
        this IServiceCollection services,
        Assembly assembly)
        {
            var mapperInterfaces = assembly.DefinedTypes
                .Where(t => t.IsInterface && t.GetCustomAttribute<MapperAttribute>() is not null);


            foreach (var mapperInterface in mapperInterfaces)
            {
                var mapperImplementations = assembly.DefinedTypes
                    .Where(t => t.IsClass && t.ImplementedInterfaces.Contains(mapperInterface))
                    .ToList();

                if (mapperImplementations is null || mapperImplementations.Any() == false)
                {
                    throw new Exception($"Имплементация для маппера \"{mapperInterface.FullName}\" не найдена.");
                }
                if (mapperImplementations.Count > 1)
                {
                    throw new Exception($"Найдена более чем одна имплементация для маппера \"{mapperInterface.FullName}\".");
                }

                var mapperImplementation = mapperImplementations.First();
                services.AddScoped(mapperInterface, mapperImplementation);
            }
            return services;
        }
    }
}
