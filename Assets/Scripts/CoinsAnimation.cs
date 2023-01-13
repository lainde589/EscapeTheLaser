using UnityEngine;

public class CoinsAnimation : MonoBehaviour
{
	public GameObject coin;

	private void FixedUpdate()
	{
		coin.transform.rotation *= Quaternion.Euler(0, 0, 3);
	}
}