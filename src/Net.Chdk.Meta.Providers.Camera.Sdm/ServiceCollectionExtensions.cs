using Microsoft.Extensions.DependencyInjection;
using Net.Chdk.Meta.Providers.Camera.Ps;

namespace Net.Chdk.Meta.Providers.Camera.Sdm
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddSdmProviders(this IServiceCollection serviceCollection)
        {
            return serviceCollection
                .AddSingleton<IAltProvider, SdmAltProvider>()
                .AddSingleton<ICameraPlatformProvider, SdmCameraPlatformProvider>()
                .AddSingleton<IRevisionProvider, SdmRevisionProvider>()
                .AddSingleton<ICameraValidator, SdmCameraValidator>()
                .AddSingleton<ICameraModelValidator, SdmCameraModelValidator>();
        }
    }
}
