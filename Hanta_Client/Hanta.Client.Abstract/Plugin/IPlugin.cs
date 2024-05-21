using Hanta.Client.Abstract.ViewModel;

namespace Hanta.Client.Abstract.Plugin;
/// <summary>
/// 플러그인 인터페이스
/// </summary>
public interface IPlugin
{
	/// <summary>
	/// 플러그인 아이콘 Kind속성 (MaterialDesign IconPack)
	/// </summary>
	string PluginIconKind { get; init; }

	/// <summary>
	/// 플러그인 메인 뷰모델
	/// </summary>
	IViewModel PluginViewModel { get; init; }

	/// <summary>
	/// 플러그인 메인 뷰
	/// </summary>
	object PluginView { get; init; }

	/// <summary>
	/// 플러그인 설정 뷰 모델
	/// </summary>
	IViewModel PluginConfigViewModel { get; init; }

	/// <summary>
	/// 플러그인 설정 뷰
	/// </summary>
	object PluginConfigView { get; init; }
}
