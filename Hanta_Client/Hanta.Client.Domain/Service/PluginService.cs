using Hanta.Client.Abstract.Plugin;
using Hanta.Client.Abstract.Service;
using System.Collections;

namespace Hanta.Client.Domain.Service;

/// <summary>
/// 플러그인 서비스 클래스
/// </summary>
public sealed class PluginService : IPluginService
{
	/// <summary>
	/// 생성자
	/// </summary>
	public PluginService()
	{
		////////////////////////////////////////
		// 카탈로그 생성
		////////////////////////////////////////
		{
			var directoryService = Ioc.Default.GetService<IDirectoryService>()!;

			string pluginFolderName = "Plugins";
			string pluginPath       = directoryService.CreateDirectoryFromAppDomain(pluginFolderName);

			if (!directoryService.CheckAndCreateDirectoryIfNotExists(pluginPath))
			{
				throw new Exception($"[{nameof(PluginService)}] Error = 폴더생성 실패");
			}

			_directoryCatalog = new(pluginPath);

			CompositionContainer container = new(_directoryCatalog);
			container.ComposeParts(this);
		}
	}

	#region Properties

	/// <summary>
	/// 플러그인 카탈로그
	/// </summary>
	private readonly DirectoryCatalog _directoryCatalog;

	/// <summary>
	/// 임포트 된 플러그인 목록
	/// </summary>
	[ImportMany(typeof(IPlugin), AllowRecomposition = true)]
	private IEnumerable<IPlugin>? _plugins { get; init; }

	#endregion

	#region Methods

	#endregion
}
