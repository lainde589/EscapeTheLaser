using UnityEngine;

public class CharacterJump : MonoBehaviour
{
	/*
	 * создаем переменную _rb для хранения в ней компонента Rigidbody
	 * (компонент нужен для управления физическим поведением игрового объекта)
	 */
	private Rigidbody _rb;
	private float _characterJumpPower = 150f;

	private void Awake()
	{
		_rb = GetComponent<Rigidbody>();
	}

	//private void OnCollisionStay(Collision collision)
	//{
	//	// прыгаем только на платформе, а не на любой поверхности
	//	bool isCharacterOnPlatform = collision.gameObject.name == "Map";

	//	if (isCharacterOnPlatform)
	//	{
	//		_rb.AddForce(new Vector3(0, 1, 0) * _characterJumpPower);
	//	}
	//}

	public void Jump()
	{
		_rb.AddForce(new Vector3(0, 1, 0) * _characterJumpPower);
	}
}
