using UnityEngine;
using UnityEngine.Localization.Settings;

public class LocalizationManager : MonoBehaviour
{
	private void Awake()
	{
		if (Application.systemLanguage == SystemLanguage.Russian)
		{
			ChangeLanguage(2); // Переключение на русский язык
		}
	}

	private void Start()
	{
		Invoke("Delay", 0.1f);
	}

	private void Delay()
	{
		int langID = PlayerPrefs.GetInt("Language");
		ChangeLanguage(langID);
	}

	public void ChangeLanguage(int langID)
	{
		LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[langID];
		PlayerPrefs.SetInt("Language", langID);
	}
}
