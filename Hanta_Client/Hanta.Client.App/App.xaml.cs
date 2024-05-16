using Hanta.Client.Views.Main;
using Hanta.Client.ViewModels.Main;

namespace Hanta.Client.App;
/// <summary>
/// Hanta Client App
/// </summary>
public partial class App : Application
{
	/// <summary>
	/// App 생성 시 Ioc컨테이너 빌드
	/// </summary>
	public App() => IocBuilder.Build();

	/// <summary>
	/// 프로그램 시작지점
	/// </summary>
	private void OnStartUp(object sender, StartupEventArgs e)
	{
		////////////////////////////////////////
		// 메인 윈도우를 생성 후 띄워준다.
		////////////////////////////////////////
		{
			this.MainWindow = new HantaWindowView()
			{
				DataContext = Ioc.Default.GetService<HantaWindowViewModel>()
			};

			this.MainWindow.Show();
		}
	}
}
