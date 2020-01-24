using Microsoft.Extensions.DependencyInjection;
using ShadySoft.Blazor.FocusService;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ShadyFocusServiceServiceCollectionExtensions
    {
        public static IServiceCollection AddBlazorFocusService(this IServiceCollection services)
        {
            return services.AddScoped<FocusService>();
        }
    }
}