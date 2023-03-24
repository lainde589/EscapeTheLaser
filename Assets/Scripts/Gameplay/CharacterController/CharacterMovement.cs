using UnityEngine;


[RequireComponent(typeof(Rigidbody), typeof(BoxCollider))]

public class CharacterMovement : MonoBehaviour
{
	///*
	// * создаем переменную _rb для хранения в ней компонента Rigidbody
	// * (компонент нужен для управления физическим поведением игрового объекта)
	// */
	//private Rigidbody _rb;
	//private float _characterSpeed = 500f;

	//private void Awake()
	//{
	//	// перед началом игры получаем компонент Rigidbody
	//	_rb = GetComponent<Rigidbody>();
	//}

	//private void FixedUpdate()
	//{
	//	/*
	//	 * метод GetAxis возвращает число, которое зависит от нажатия на стрелки
	//	 * вверх (1) или вниз (-1) по горизонтальной оси
	//	 * влево (1) или вправо (-1) по вертикальной оси
	//	 */
	//	float directionX = Input.GetAxis("Horizontal") * _characterSpeed * Time.fixedDeltaTime;
	//	float directionZ = Input.GetAxis("Vertical") * _characterSpeed * Time.fixedDeltaTime;
	//	float directionY = _rb.velocity.y;

	//	_rb.velocity = transform.TransformDirection(new Vector3(directionX, directionY, directionZ));
	//}



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
