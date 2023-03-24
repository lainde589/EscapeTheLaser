using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
	public void LoadLevelsListScene()
	{
		SceneManager.LoadScene("LevelsListScene");
	}

	public void LoadSettingsScene()
	{
		SceneManager.LoadScene("SettingsScene");
	}

	public void QuitGame()
	{
		Application.Quit();
	}
}