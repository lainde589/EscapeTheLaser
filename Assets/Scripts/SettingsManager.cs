using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsManager : MonoBehaviour
{
	public void BackToMainMenu()
	{
		SceneManager.LoadScene("MainMenu");
	}
}
