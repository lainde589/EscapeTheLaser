using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuManager : MonoBehaviour
{
	[SerializeField] GameObject pause;

	private void Start()
	{
		pause.SetActive(false);
	}

	public void ShowPauseMenu()
	{
		pause.SetActive(true);
		Time.timeScale = 0;
	}

	public void HidePauseMenu()
	{
		pause.SetActive(false);
		Time.timeScale = 1;
	}

	public void RestartLevel()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		Time.timeScale = 1;
	}

	public void BackToMainMenu()
	{
		SceneManager.LoadScene("MainMenu");
		Time.timeScale = 1;
	}
}
