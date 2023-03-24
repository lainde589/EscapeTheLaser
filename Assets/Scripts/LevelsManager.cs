using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsManager : MonoBehaviour
{
	[SerializeField] GameObject popupWindow;

	// Всплывающее окно не отображается
	private void Start()
	{
		popupWindow.SetActive(false);
	}


	public void LoadLevel(int levelID)
	{
		SceneManager.LoadScene(levelID);
	}

	public void BackToMainMenu()
	{
		SceneManager.LoadScene("MainMenu");
	}
	


	// Временно!
	public void ShowPopupWindow()
	{
		popupWindow.SetActive(true);
	}

	public void HidePopupWindow()
	{
		popupWindow.SetActive(false);
	}
}