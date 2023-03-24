using UnityEngine;

public class CoinsGeneration : MonoBehaviour
{
	public GameObject coin;

	private void GenerateCoins()
	{
		for (int i = 0; i < 4; i++)
		{
			Vector3 randomCoinPosition = new Vector3(Random.Range(-18, 18), 1, Random.Range(-8, 10));
			coin.transform.position = randomCoinPosition;
		}
	}

	private void Start()
	{
		GenerateCoins();
	}
}
