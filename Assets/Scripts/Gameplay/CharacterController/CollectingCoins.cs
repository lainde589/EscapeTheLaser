using UnityEngine;
using UnityEngine.UI;

public class CollectingCoins : MonoBehaviour
{
	public Text scoreText;
	private byte _collectedCoins;


	private void OnTriggerEnter(Collider other)
	{
		bool isCharacterCollidingWithCoin = other.CompareTag("Coins");

		if (isCharacterCollidingWithCoin)
		{
			Destroy(other.gameObject);
			_collectedCoins++;

			scoreText.text = $"Coins: {_collectedCoins}";
		}
	}
}