using UnityEngine;


[RequireComponent(typeof(Rigidbody), typeof(BoxCollider))]

public class CharacterMovement : MonoBehaviour
{
	[SerializeField] private Rigidbody _rigidbody;
	[SerializeField] private FixedJoystick _joystick;
	[SerializeField] private Animator _animator;
	
	[SerializeField] private float _moveSpeed;

	private void FixedUpdate()
	{
		_rigidbody.velocity = new Vector3(_joystick.Horizontal * _moveSpeed, _rigidbody.velocity.y, _joystick.Vertical * _moveSpeed);


		// Поворачивание персонажа
		if (_joystick.Horizontal != 0 || _joystick.Vertical != 0)
		{
			transform.rotation = Quaternion.LookRotation(_rigidbody.velocity);
		}
	}
}
