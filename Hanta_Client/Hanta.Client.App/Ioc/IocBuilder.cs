using Hanta.Client.ViewModels.Main;

namespace Hanta.Client.App;

/// <summary>
/// Hanta Client Ioc Container Builder
/// </summary>
public static class IocBuilder
{
	/// <summary>
	/// Ioc Container 빌드
	/// </summary>
	public static void Build()
	{
		var services = ConfigureService();

		Ioc.Default.ConfigureServices(services);
	}

	/// <summary>
	/// Service Provider 설정
	/// </summary>
	/// <returns> Service Provider </returns>
	private static IServiceProvider ConfigureService()
	{
		var services = new ServiceCollection();


		////////////////////////////////////////
		// Main ViewModels
		////////////////////////////////////////
		{
			services.AddTransient<HantaWindowViewModel>();
		}


		return services.BuildServiceProvider();
	}
}
