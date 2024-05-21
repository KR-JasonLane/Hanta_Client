using Hanta.Client.Abstract.Plugin;
using Hanta.Client.Abstract.Service;
using Hanta.Client.Abstract.ViewModel;

namespace Hanta.Client.ViewModels.Main;
/// <summary>
/// Hanta Client 메인윈도우 뷰모델
/// </summary>
public partial class HantaWindowViewModel : ObservableRecipient, IViewModel
{
	/// <summary>
	/// 생성자
	/// </summary>
	public HantaWindowViewModel(IPluginService pluginService)
	{
		////////////////////////////////////////
		// 서비스
		////////////////////////////////////////
		{
			_pluginService = pluginService;
		}


		////////////////////////////////////////
		// 속성초기화
		////////////////////////////////////////
		{
			Plugins = new();
		}
	}

	#region Properties

	private readonly IPluginService _pluginService;

	[ObservableProperty]
	private ObservableCollection<IPlugin> _plugins;
	

	#endregion

	#region Methods

	#endregion

	#region Partials

	#endregion

	#region Commands

	#endregion
}
