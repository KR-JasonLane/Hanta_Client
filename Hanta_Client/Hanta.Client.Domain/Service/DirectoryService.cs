using Hanta.Client.Abstract.Service;

namespace Hanta.Client.Domain.Service;

/// <summary>
/// 디렉토리 핸들링 서비스 클래스
/// </summary>
public sealed class DirectoryService : IDirectoryService
{
	/// <summary>
	/// 생성자
	/// </summary>
	public DirectoryService()
	{

	}

	#region Properties

	#endregion

	#region Methods

	/// <summary>
	/// 폴더이름을 받아 어플리케이션이 실행되는 위치에 해당하는 경로를 반환
	/// </summary>
	/// <param name="FolderName"> 폴더 이름 </param>
	/// <returns>어플리케이션이 실행되는 위치에 포함된 매개변수 폴더이름의 경로 </returns>
	public string CreateDirectoryFromAppDomain(string FolderName) => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, FolderName);


	/// <summary>
	/// 매개변수 폴더경로를 검사 후 없으면 생성
	/// </summary>
	/// <param name="directoryPath"> 검사할 폴더 경로 </param>
	/// <returns> 성공여부 </returns>
	public bool CheckAndCreateDirectoryIfNotExists(string directoryPath)
	{
		try
		{
			if (!Directory.Exists(directoryPath))
			{
				Directory.CreateDirectory(directoryPath);
			}
		}
		catch (Exception ex)
		{
			Debug.WriteLine(ex);
			return false;
		}

		return true;
	}

	#endregion
}
